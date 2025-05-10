CREATE TABLE usuario(
id_usuario SERIAL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
email VARCHAR(35),
area_trabalho VARCHAR(35)
);

CREATE TABLE tecnico(
id_tecnico SERIAL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
email VARCHAR(50)
);

CREATE TABLE solucao(
id_solucao SERIAL PRIMARY KEY,
descricao TEXT,
data_registro DATE,
fk_tecnico_id_tecnico INTEGER NOT NULL,
FOREIGN KEY(fk_tecnico_id_tecnico) REFERENCES tecnico(id_tecnico)
);

CREATE TABLE chamado(
id_chamado SERIAL PRIMARY KEY,
status VARCHAR(50),
prioridade VARCHAR(50),
descricao TEXT,
data_abertura DATE,
data_fechamento DATE,
fk_usuario_id_usuario INTEGER NOT NULL,
fk_solucao_id_solucao INTEGER,
FOREIGN KEY (fk_usuario_id_usuario) REFERENCES usuario(id_usuario),
FOREIGN KEY (fk_solucao_id_solucao) REFERENCES solucao(id_solucao)
);