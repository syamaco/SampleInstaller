var xs = {
    "123":{"Id":"123","category":1,"field1":2,"field2":3,"name":"foo","seq":0},
    "223":{"Id":"223","category":2,"field1":2,"field2":3,"name":"bar","seq":1},
    "131":{"Id":"131","category":1,"field1":3,"field2":1,"name":"buz","seq":2}
};
var ys = Object.keys(xs).map(function (key) { return xs[key]; }).sort(function (a, b) { return a.seq - b.seq })
