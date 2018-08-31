function solve(arr) {
    var players = [];

    arr.forEach(function (element) {
        var fstName = '';
        var scdName = '';
        var fstGamesWon = 0;
        var scdGamesWon = 0;
        var fstGamesLost = 0;
        var scdGamesLost = 0;
        var fstSetsWon = 0;
        var scdSetsWon = 0;
        var fstSetsLost = 0;
        var scdSetsLost = 0;
        var fstMatchesWon = 0;
        var scdMatchesWon = 0;
        var fstMatchesLost = 0;
        var scdMatchesLost = 0;
        var current;
        var dataNames = element.split(':');
        var bothNames = dataNames[0].split('vs.');
        fstName = bothNames[0].replace(/\s+/g, ' ').trim();
        scdName = bothNames[1].replace(/\s+/g, ' ').trim();
        var thisGame = dataNames[1].replace(/\s+/g, ' ').trim().split(' ');
        var thisGameFstGames = 0;
        var thisGameScdGames = 0;
        var thisGameFstSets = 0;
        var thisGameScdSets = 0;
        thisGame.forEach(function (el) {
            var thisGameData = el.split('-');
            thisGameFstGames = Number(thisGameData[0]);
            thisGameScdGames = Number(thisGameData[1]);
            if (thisGameFstGames > thisGameScdGames) {
                thisGameFstSets++;
                fstGamesWon += thisGameFstGames;
                fstGamesLost += thisGameScdGames;
                scdGamesLost += thisGameFstGames;
                scdGamesWon += thisGameScdGames;
            } else {
                thisGameScdSets++;
                scdGamesWon += thisGameScdGames;
                scdGamesLost += thisGameFstGames;
                fstGamesLost += thisGameScdGames;
                fstGamesWon += thisGameFstGames;
            }
        });
        if (thisGameFstSets > thisGameScdSets) {
            fstMatchesWon++;
            scdMatchesLost++;
            fstSetsWon += thisGameFstSets;
            scdSetsLost += thisGameFstSets;
            fstSetsLost += thisGameScdSets;
            scdSetsWon += thisGameScdSets;
        } else {
            scdMatchesWon++;
            fstMatchesLost++;
            scdSetsWon += thisGameScdSets;
            fstSetsLost += thisGameScdSets;
            scdSetsLost += thisGameFstSets;
            fstSetsWon += thisGameFstSets;
        }
        var firstPlayer = {
            "name": fstName,
            "matchesWon": fstMatchesWon,
            "matchesLost": fstMatchesLost,
            "setsWon": fstSetsWon,
            "setsLost": fstSetsLost,
            "gamesWon": fstGamesWon,
            "gamesLost": fstGamesLost
        };
        var secondPlayer = {
            "name": scdName,
            "matchesWon": scdMatchesWon,
            "matchesLost": scdMatchesLost,
            "setsWon": scdSetsWon,
            "setsLost": scdSetsLost,
            "gamesWon": scdGamesWon,
            "gamesLost": scdGamesLost
        };

        if (!checkPlayer(fstName)) {
            players.push(firstPlayer);
        } else {
            current = checkPlayer(fstName);
            current.matchesWon += firstPlayer.matchesWon;
            current.matchesLost += firstPlayer.matchesLost;
            current.setsWon += firstPlayer.setsWon;
            current.setsLost += firstPlayer.setsLost;
            current.gamesWon += firstPlayer.gamesWon;
            current.gamesLost += firstPlayer.gamesLost;

        }
        if (!checkPlayer(scdName)) {
            players.push(secondPlayer);
        } else {
            current = checkPlayer(scdName);
            current.matchesWon += secondPlayer.matchesWon;
            current.matchesLost += secondPlayer.matchesLost;
            current.setsWon += secondPlayer.setsWon;
            current.setsLost += secondPlayer.setsLost;
            current.gamesWon += secondPlayer.gamesWon;
            current.gamesLost += secondPlayer.gamesLost;
        }
    });
    players.sort(function (a, b) {
        if (a.matchesWon !== b.matchesWon) {
            return b.matchesWon - a.matchesWon;
        }
        if (a.setsWon !== b.setsWon) {
            return b.setsWon - a.setsWon;
        }
        if (a.gamesWon !== b.gamesWon) {
            return b.gamesWon - a.gamesWon;
        }
        return a.name.localeCompare(b.name);
    });

    console.log(JSON.stringify(players));

    function checkPlayer(name) {
        return players.filter(function (el) {
            return el.name == name;
        })[0];
    }
}

var arr = ['Novak Djokovic vs. Roger Federer : 6-3 6-3',
    'Roger    Federer    vs.        Novak Djokovic    :         6-2 6-3',
    'Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
    'Andy Murray vs. David Ferrer : 6-4 7-6',
    'Tomas Bedrych vs. Kei Nishikori : 4-6 6-4 6-3 4-6 5-7',
    'Grigor Dimitrov vs. Milos Raonic : 6-3 4-6 7-6 6-2',
    'Pete Sampras vs. Andre Agassi : 2-1',
    'Boris Beckervs.Andre        \t\t\tAgassi:2-1'];

solve(arr);