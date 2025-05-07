CREATE TABLE usuario(
id_usuario SERIAL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
email VARCHAR(35),
area_trabalho VARCHAR(35)
);

CREATE TABLE telefone_usuario(
telefone_usuario VARCHAR(20) PRIMARY KEY,
tipo_telefone VARCHAR(20),
fk_usuario_id_usuario INTEGER NOT NULL,
FOREIGN KEY (fk_usuario_id_usuario) REFERENCES usuario(id_usuario)
);

CREATE TABLE tecnico(
id_tecnico SERIAL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
especialidade VARCHAR(35)
);

CREATE TABLE telefone_tecnico(
telefone_tecnico VARCHAR(20) PRIMARY KEY,
tipo_telefone VARCHAR(20),
fk_tecnico_id_tecnico INTEGER NOT NULL,
FOREIGN KEY (fk_tecnico_id_tecnico) REFERENCES tecnico(id_tecnico)
);

CREATE TABLE setor(
id_setor SERIAL PRIMARY KEY,
nome VARCHAR(35) NOT NULL,
local VARCHAR(35) NOT NULL
);

CREATE TABLE equipamento(
id_equipamento SERIAL PRIMARY KEY,
nome VARCHAR(35) NOT NULL,
modelo VARCHAR(35) NOT NULL
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
fk_setor_id_setor INTEGER NOT NULL,
fk_equipamento_id_equipamento INTEGER NOT NULL,
fk_solucao_id_solucao INTEGER,
FOREIGN KEY (fk_usuario_id_usuario) REFERENCES usuario(id_usuario),
FOREIGN KEY (fk_setor_id_setor) REFERENCES setor(id_setor),
FOREIGN KEY (fk_equipamento_id_equipamento) REFERENCES equipamento(id_equipamento),
FOREIGN KEY (fk_solucao_id_solucao) REFERENCES solucao(id_solucao)
);