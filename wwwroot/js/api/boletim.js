
async function procurarAlunos() {
    const result = await fetch(`https://localhost:7173/api/Alunos`)
    const Alunos = await result.json()

    const aluno_select = document.getElementById("aluno")
    aluno_select.innerHTML = ``
    for (var aluno of Alunos) {
        aluno_select.innerHTML += `
        <option value="${aluno.id}">ID: ${aluno.id} | ${aluno.nome}</option>
        `
    }
}

async function procurarTurmas() {
    const result = await fetch(`https://localhost:7173/api/Turmas`)
    const turmas = await result.json()

    const turma_select = document.getElementById("turma")
    turma_select.innerHTML = ``
    for (var turma of turmas) {
        turma_select.innerHTML += `
        <option value="${turma.id}">ID: ${turma.id} | ${turma.nomeTurma}</option>
        `
    }
}