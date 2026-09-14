const API_URL = "https://localhost:7173/api/Disciplinas"

async function procurarDisciplinas() {
    const result = await fetch(`${API_URL}`)
    const disciplinas  = await result.json()
    return disciplinas 
}

async function adicionarDisciplina() {
    const nomeDisciplina = document.getElementById("nomeDisciplina").value
    const CargaHoraria = document.getElementById("CargaHoraria").value

    try {
        const payload = {
            nomeDisciplina: nomeDisciplina,
            CargaHoraria: CargaHoraria,
        }
        const response = await fetch(API_URL, {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(payload)
        })
    } catch (error) {
        alert("Um Erro ocorreu. Tente novamente mais tarde")
    }
    alterarTabela()
}

async function alterarTabela() {
    var tabela = document.getElementById("tabela-disciplinas")
    const disciplinas = await procurarDisciplinas()

    tabela.innerHTML = ``

    for (const disciplina of disciplinas){
        tabela.innerHTML += `
        <tr>
            <td>${disciplina.id}</td>
            <td>${disciplina.nomeDisciplina}</td>
            <td>${disciplina.cargaHoraria}</td>
            <th><a>Editar</a></th>
            <th><a>Detalhes</a></th>
            <th><button class="delete" onclick=deletarDisciplina(${disciplina.id})>Delete</button></th>
        </tr>
        `
    }
}

async function deletarDisciplina(id){
    const confirmacao = confirm("Tem certeza que quer apagar a Disciplina?")
    if (!confirmacao){
        return
    }
    const response = await fetch(`${API_URL}/${id}`,{
        method: "DELETE",
        headers: {
            'Content-Type': 'application/json'
        }
    }
    )
    alterarTabela()
}
