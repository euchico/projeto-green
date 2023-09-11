CREATE TABLE ConcursoDiaDeSorte (
    id INT PRIMARY KEY,
	concurso INT,
	data DATE,
	local VARCHAR(255),
	-- DezenasOrdemSorteio
	-- Dezenas
	mesSorte VARCHAR(255),
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

CREATE TABLE Dezenas (
    id INT PRIMARY KEY,
    dezena INT
);

CREATE TABLE ConcursoDiaDeSorte_DezenasOrdemSorteio (
    id INT PRIMARY KEY,
    concursoid INT,
    dezenasid INT,
	ordem INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDiaDeSorte (id),
    FOREIGN KEY (dezenasid) REFERENCES Dezenas (id)
);

CREATE TABLE ConcursoDiaDeSorte_Dezenas (
    id INT PRIMARY KEY,
    concursoid INT,
    dezenasid INT,
	posicao INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDiaDeSorte (id),
    FOREIGN KEY (dezenasid) REFERENCES Dezenas (id)
);

CREATE TABLE Premiacoes (
    id INT PRIMARY KEY,
    descricao VARCHAR(255),
    faixa INT,
	ganhadores INT,
    valorPremio DECIMAL
);

CREATE TABLE ConcursoDiaDeSorte_Premiacoes (
    id INT PRIMARY KEY,
    concursoid INT,
    premiacoesid INT,
    FOREIGN KEY (concursoid) REFERENCES ConcursoDiaDeSorte (id),
    FOREIGN KEY (premiacoesid) REFERENCES Premiacoes (id)
);

CREATE TABLE Estados (
    id INT PRIMARY KEY,
	nome VARCHAR(255),
    sigla VARCHAR(255)
);

CREATE TABLE ConcursoDiaDeSorte_EstadosPremiados (
    id INT PRIMARY KEY,
    concursoid INT,
	estadosid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoDiaDeSorte (id),
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

CREATE TABLE ConcursoDiaDeSorte_LocalGanhadores (
    id INT PRIMARY KEY,
    concursoid INT,
	localid INT,
	FOREIGN KEY (concursoid) REFERENCES ConcursoDiaDeSorte (id),
	FOREIGN KEY (localid) REFERENCES LocalGanhadores (id)
);