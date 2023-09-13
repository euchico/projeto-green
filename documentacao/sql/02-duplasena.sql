CREATE TABLE ConcursoDuplaSena (
    id INT PRIMARY KEY,
	concurso INT,
	data DATE,
	local VARCHAR(255),
	-- DezenasOrdemSorteio
	-- Dezenas
	-- Premiacoes
	-- EstadosPremiados
	estadosPremiados VARCHAR(255),
	observacao VARCHAR(255),
	acumulou BIT,
	proximoConcurso INT,
	dataProximoConcurso DATE,
	-- LocalGanhadores
	valorArrecadado DECIMAL,
	valorAcumuladoProximoConcurso DECIMAL,
	valorEstimadoProximoConcurso DECIMAL,
);

CREATE TABLE ConcursoDuplaSena_DezenasOrdemSorteio (
    id INT PRIMARY KEY,
    concursoid INT,
	posicao INT,
    dezenas INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDuplaSena (id)
);

CREATE TABLE ConcursoDuplaSena_Dezenas (
    id INT PRIMARY KEY,
    concursoid INT,
    dezenas INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDuplaSena (id)
);

CREATE TABLE Premiacoes (
    id INT PRIMARY KEY,
    descricao VARCHAR(255),
    faixa INT,
	ganhadores INT,
    valorPremio DECIMAL
);

CREATE TABLE ConcursoDuplaSena_Premiacoes (
    id INT PRIMARY KEY,
    concursoid INT,
    premiacoesid INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDuplaSena (id),
    FOREIGN KEY (premiacoesid) REFERENCES Premiacoes (id)
);

CREATE TABLE Estados (
    id INT PRIMARY KEY,
	nome VARCHAR(255),
    sigla VARCHAR(255)
);

CREATE TABLE ConcursoDuplaSena_EstadosPremiados (
    id INT PRIMARY KEY,
    concursoid INT,
	estadosid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoDuplaSena (id),
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

CREATE TABLE ConcursoDuplaSena_LocalGanhadores (
    id INT PRIMARY KEY,
    concursoid INT,
	localid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoDuplaSena (id),
	FOREIGN KEY (localid) REFERENCES LocalGanhadores (id)
);