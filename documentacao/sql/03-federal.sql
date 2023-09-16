CREATE TABLE ConcursoFederal (
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
	proximoConcurso INT
);

CREATE TABLE ConcursoFederal_DezenasOrdemSorteio (
    id INT PRIMARY KEY,
    concursoid INT,
	numeroSorteio INT,
	posicao INT,
    dezenas VARCHAR(255),
    FOREIGN KEY (concursoid) REFERENCES ConcursoFederal (id)
);

CREATE TABLE ConcursoFederal_Dezenas (
    id INT PRIMARY KEY,
    concursoid INT,
	numeroSorteio INT,
    dezenas VARCHAR(255),
    FOREIGN KEY (concursoid) REFERENCES ConcursoFederal (id)
);

CREATE TABLE Premiacoes (
    id INT PRIMARY KEY,
    descricao VARCHAR(255),
    faixa INT,
	ganhadores INT,
    valorPremio DECIMAL
);

CREATE TABLE ConcursoFederal_Premiacoes (
    id INT PRIMARY KEY,
    concursoid INT,
    premiacoesid INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoFederal (id),
    FOREIGN KEY (premiacoesid) REFERENCES Premiacoes (id)
);

CREATE TABLE Estados (
    id INT PRIMARY KEY,
	nome VARCHAR(255),
    sigla VARCHAR(255)
);

CREATE TABLE ConcursoFederal_EstadosPremiados (
    id INT PRIMARY KEY,
    concursoid INT,
	estadosid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoFederal (id),
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

CREATE TABLE ConcursoFederal_LocalGanhadores (
    id INT PRIMARY KEY,
    concursoid INT,
	localid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoFederal (id),
	FOREIGN KEY (localid) REFERENCES LocalGanhadores (id)
);