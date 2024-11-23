const { add, sub } = require("../src/index.js");

test('Testando a função de adicionar', () => {
    expect(add(1,2)).toBe(3)
})

test('Testando a função de subtrair', () => {
    expect(sub(2,1)).toBe(1)
})