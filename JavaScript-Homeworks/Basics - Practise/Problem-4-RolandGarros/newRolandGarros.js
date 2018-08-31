function solve(arr) {
    var players = [];

    for (var i = 0; i < arr.length; i++) {
        var inputData = arr[i].split(':');
        var inputName = inputData[0].split('vs.');
        var inputResults = inputData[1].replace(/[\s-]+/g, ' ').trim();
        var fstPlayerName = inputName[0].replace(/\s+/g, ' ').trim();
        var sndPlayerName = inputName[1].replace(/\s+/g, ' ').trim();
        var fstMatchWon = 0, fstMatchLost = 0, fstSetWon = 0, fstSetLost = 0, fstGameWon = 0, fstGameLost = 0;
        var sndMatchWon = 0, sndMatchLost = 0, sndSetWon = 0, sndSetLost = 0, sndGameWon = 0, sndGameLost = 0;
        var thisGame = inputResults.split(' ').map(function (int) {
            return Number(int)
        });

        thisGameEval();
        updatePlayer(fstPlayerName, fstMatchWon, fstMatchLost, fstSetWon, fstSetLost, fstGameWon, fstGameLost);
        updatePlayer(sndPlayerName, sndMatchWon, sndMatchLost, sndSetWon, sndSetLost, sndGameWon, sndGameLost);
    }

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

    function updatePlayer(name, matchesWon, matchesLost, setsWon, setsLost, gamesWon, gamesLost) {
        var currentPlayer = players.filter(function (el) {
            return el.name === name;
        })[0];

        if (!currentPlayer) {
            players.push({
                name: name,
                matchesWon: matchesWon,
                matchesLost: matchesLost,
                setsWon: setsWon,
                setsLost: setsLost,
                gamesWon: gamesWon,
                gamesLost: gamesLost
            })
        } else {
            currentPlayer.matchesWon += matchesWon;
            currentPlayer.matchesLost += matchesLost;
            currentPlayer.setsWon += setsWon;
            currentPlayer.setsLost += setsLost;
            currentPlayer.gamesWon += gamesWon;
            currentPlayer.gamesLost += gamesLost;
        }
    }


    function thisGameEval() {
        for (var j = 0; j < thisGame.length; j++) {
            if (j % 2 != 0) {
                fstGameLost += thisGame[j];
                sndGameWon += thisGame[j];
                if (thisGame[j] > thisGame[j - 1]) {
                    sndSetWon += 1;
                    fstSetLost += 1;
                } else {
                    sndSetLost += 1;
                    fstSetWon += 1;
                }
            } else {
                fstGameWon += thisGame[j];
                sndGameLost += thisGame[j];
            }
        }
        if (fstSetWon > sndSetWon) {
            fstMatchWon += 1;
            sndMatchLost += 1;
        } else {
            fstMatchLost += 1;
            sndMatchWon += 1;
        }
        return j;
    }
}

var arr = [' Novak     Djokovic     vs.         Roger      Federer     :    6-3   6-3              ',
    'Roger    Federer    vs.        Novak Djokovic    :         6-2 6-3',
    'Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
    'Andy Murray vs. David Ferrer : 6-4 7-6',
    'Tomas Bedrych vs. Kei Nishikori : 4-6 6-4 6-3 4-6 5-7',
    'Grigor Dimitrov vs. Milos Raonic : 6-3 4-6 7-6 6-2',
    'Pete Sampras vs. Andre Agassi : 2-1',
    'Boris Beckervs.Andre        \t\t\tAgassi:2-1'];
solve(arr);