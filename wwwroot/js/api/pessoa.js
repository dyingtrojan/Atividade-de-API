const API_URL = "https://localhost:7173/api"


async function adicionarPessoa() {
    const nome = document.getElementById("nome").value
    const idade = document.getElementById("idade").value
    const email = document.getElementById("email").value
    const cpf = document.getElementById("cpf").value
    const senha = document.getElementById("senha").value
    const tipoPessoa = document.getElementById("tipoUsuario").value

    switch (tipoPessoa) {
        case "Aluno":
            const payload = {
                nome: nome,
                idade: idade,
                email: email,
                cpf: cpf,
                hashSenha: senha,
                tipoPessoa: tipoPessoa,
                status: "Matriculado",
                turmaId: null
            }
            const resposta = await fetch(`${API_URL}/Alunos`,{
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(payload)
            }
            )
            break;
    
        case "Professor":
            try{
                const payload = {
                    nome: nome,
                    idade: idade,
                    email: email,
                    hashSenha: senha,
                    tipoPessoa: tipoPessoa
                }
                const resposta = await fetch(`${API_URL}/Professores`,{
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(payload)
                }
                )
            } catch(error){
                alert("Um erro ocorreu. Tente mais tarde.")
            }
            break;

        case "Administrador":
            try{
                const payload = {
                    nome: nome,
                    idade: idade,
                    email: email,
                    hashSenha: senha,
                    tipoPessoa: tipoPessoa
                }
                const resposta = await fetch(`${API_URL}/Administradores`,{
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(payload)
                }
                )
            } catch(error){
                alert("Um erro ocorreu. Tente mais tarde.")
            }
            break;
    }
}

async function gerarHashSenha(senha) {
    const encoder = new TextEncoder();
    const data = encoder.encode(senha);
    
    const hashBuffer = await crypto.subtle.digest('SHA-256', data);

    const hashArray = Array.from(new Uint8Array(hashBuffer));
    const hashHex = hashArray.map(b => b.toString(16).padStart(2, '0')).join('');

    return hashHex;
}