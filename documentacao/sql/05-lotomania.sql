CREATE TABLE ConcursoLotomania (
    id INT PRIMARY KEY,
	concurso INT,
	data DATE,
	local VARCHAR(255),
	-- DezenasOrdemSorteio
	-- Dezenas
	-- Premiacoes
	-- EstadosPremiados
	observacao VARCHAR(255),
	acumulou BIT,
	proximoConcurso INT,
	dataProximoConcurso DATE,
	-- LocalGanhadores
	valorArrecadado DECIMAL,
	valorAcumuladoProximoConcurso DECIMAL,
	valorEstimadoProximoConcurso DECIMAL
);

CREATE TABLE ConcursoLotomania_DezenasOrdemSorteio (
    id INT PRIMARY KEY,
    concursoid INT,
	posicao INT,
    dezenas INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoLotomania (id)
);

CREATE TABLE ConcursoLotomania_Dezenas (
    id INT PRIMARY KEY,
    concursoid INT,
    dezenas INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoLotomania (id)
);

CREATE TABLE Premiacoes (
    id INT PRIMARY KEY,
    descricao VARCHAR(255),
    faixa INT,
	ganhadores INT,
    valorPremio DECIMAL
);

CREATE TABLE ConcursoLotomania_Premiacoes (
    id INT PRIMARY KEY,
    concursoid INT,
    premiacoesid INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoLotomania (id),
    FOREIGN KEY (premiacoesid) REFERENCES Premiacoes (id)
);

CREATE TABLE Estados (
    id INT PRIMARY KEY,
	nome VARCHAR(255),
    sigla VARCHAR(255)
);

CREATE TABLE ConcursoLotomania_EstadosPremiados (
    id INT PRIMARY KEY,
    concursoid INT,
	estadosid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoLotomania (id),
	FOREIGN KEY (estadosid) REFERENCES Estados (id)
);

CREATE TABLE LocalGanhadores (
    id INT PRIMARY KEY,
	ganhadores INT,
	municipio VARCHAR(255),
	nomeFatansiaUL VARCHAR(255),
	serie INT,
	posicao INT,
	estadoid INT,
	FOREIGN KEY (estadoid) REFERENCES Estados(id)
);

CREATE TABLE ConcursoLotomania_LocalGanhadores (
    id INT PRIMARY KEY,
    concursoid INT,
	localid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoLotomania (id),
	FOREIGN KEY (localid) REFERENCES LocalGanhadores (id)
);