const API_URL = "https://localhost:7173/api/Alunos"

async function procurarAlunos() {
    const result = await fetch(API_URL)
    const alunos = await result.json()
    return alunos
}

async function atualizarTurmas() {
    const response = await fetch("https://localhost:7173/api/Turmas")
    const turmas = await response.json()
    const turmaSelect = document.getElementById("turma")

    for (const turma of turmas) {
        turmaSelect.innerHTML += `
        <option value="${turma.id}">${turma.id} | ${turma.nomeTurma} (${turma.turno}) | ${turma.anoLetivo}</option>
        `
    }
}

async function alterarTabela() {
    var tabela = document.getElementById("tabela-alunos")
    const alunos = await procurarAlunos()

    tabela.innerHTML = ``

    for (const aluno of alunos) {
        tabela.innerHTML += `
        <tr>
            <td>${aluno.id}</td>
            <td>${aluno.matricula}</td>
            <td>${aluno.nome}</td>
            <td>${aluno.idade}</td>
            <td>${aluno.cpf}</td>
            <td>${aluno.email}</td>
            <td>${aluno.status}</td>
            <td>${aluno.turma.nomeTurma}</td>
            <th><a>Editar</a></th>
            <th><a>Detalhes</a></th>
            <th><button class="delete" onclick=deletarAluno(${aluno.id})>Delete</button></th>
        </tr>
        `
    }
}

async function adicionarAluno() {
    const nome = document.getElementById("nome").value
    const idade = document.getElementById("idade").value
    const email = document.getElementById("email").value
    const cpf = document.getElementById("cpf").value
    const turmaId = document.getElementById("turma").value

    const payload = {
        nome: nome,
        idade: idade,
        email: email,
        cpf: cpf,
        hashSenha: "12345678",
        tipoPessoa: "Aluno",
        status: "Matriculado",
        turmaId: parseInt(turmaId)
    }
    const resposta = await fetch(`${API_URL}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(payload)
    }
    )
    alterarTabela()
}

async function deletarAluno(id) {
    const confirmacao = confirm("Tem certeza que quer apagar o aluno?")
    if (!confirmacao) {
        return
    }
    const response = await fetch(`${API_URL}/${id}`, {
        method: "DELETE",
        headers: {
            'Content-Type': 'application/json'
        }
    }
    )
    alterarTabela()
}