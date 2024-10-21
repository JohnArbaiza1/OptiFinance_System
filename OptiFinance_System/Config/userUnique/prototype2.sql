CREATE TABLE tipo_cuenta
(
    id     BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre NVARCHAR(255) NOT NULL
);

CREATE TABLE cuentas
(
    id             BIGINT PRIMARY KEY IDENTITY (1,1),
    codigo         NVARCHAR(20)  NOT NULL,
    nombre         NVARCHAR(200) NOT NULL,
    id_tipo_cuenta BIGINT        NOT NULL,
    FOREIGN KEY (id_tipo_cuenta) REFERENCES tipo_cuenta (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tipo_usuario
(
    id     BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre NVARCHAR(20) NOT NULL
);

CREATE TABLE usuarios
(
    id              BIGINT PRIMARY KEY IDENTITY (1,1),
    nombres         NVARCHAR(200)        NOT NULL,
    apellidos       NVARCHAR(200)        NOT NULL,
    alias           NVARCHAR(12) UNIQUE  NOT NULL,
    email           NVARCHAR(200) UNIQUE DEFAULT 'No especificado',
    password        NVARCHAR(200)        NOT NULL,
    dui             NVARCHAR(10) UNIQUE  NOT NULL,
    telefono        NVARCHAR(8) UNIQUE   NOT NULL,
    direccion       NVARCHAR(300)                 DEFAULT 'No especificado',
    id_tipo_usuario BIGINT               NOT NULL DEFAULT 2,
    FOREIGN KEY (id_tipo_usuario) REFERENCES tipo_usuario (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE departamentos
(
    id     BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre NVARCHAR(100) NOT NULL UNIQUE,
    codigo NVARCHAR(6) UNIQUE
);

CREATE TABLE municipios
(
    id              BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre          NVARCHAR(100) NOT NULL UNIQUE,
    id_departamento BIGINT        NOT NULL,
    FOREIGN KEY (id_departamento) REFERENCES departamentos (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE distritos
(
    id           BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre       NVARCHAR(100) NOT NULL,
    id_municipio BIGINT        NOT NULL,
    FOREIGN KEY (id_municipio) REFERENCES municipios (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE empresas
(
    id                  BIGINT PRIMARY KEY IDENTITY (1,1),
    nombre              NVARCHAR(300) NOT NULL,
    nit                 NVARCHAR(17) UNIQUE,
    giro_economico      NVARCHAR(300) NOT NULL,
    representante_legal NVARCHAR(300) NOT NULL DEFAULT 'No especificado',
    direccion           NVARCHAR(300),
    telefono            NVARCHAR(8)   NOT NULL UNIQUE,
    email               NVARCHAR(200) UNIQUE   DEFAULT 'No especificado',
    id_usuario          BIGINT        NOT NULL,
    id_distrito         BIGINT        NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES usuarios (id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_distrito) REFERENCES distritos (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE miembros_empresa
(
    id                 BIGINT PRIMARY KEY IDENTITY (1,1),
    nombres            NVARCHAR(200) NOT NULL,
    apellidos          NVARCHAR(200) NOT NULL,
    alias              NVARCHAR(12)  NOT NULL UNIQUE,
    password           NVARCHAR(200) NOT NULL,
    dui                NVARCHAR(10)  NOT NULL UNIQUE,
    email NVARCHAR(200) UNIQUE DEFAULT 'No especificado',
    telefono           NVARCHAR(8) UNIQUE   DEFAULT 'No especificado',
    direccion          NVARCHAR(300) NOT NULL,
    id_empresa         BIGINT        NOT NULL,
    FOREIGN KEY (id_empresa) REFERENCES empresas (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE partidas
(
    id         BIGINT PRIMARY KEY IDENTITY (1,1),
    detalles   NVARCHAR(500) NOT NULL,
    fecha      DATE          NOT NULL,
    id_empresa BIGINT        NOT NULL,
    FOREIGN KEY (id_empresa) REFERENCES empresas (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE registros
(
    id         BIGINT PRIMARY KEY IDENTITY (1,1),
    debe       DECIMAL(20, 2) NOT NULL,
    haber      DECIMAL(20, 2) NOT NULL,
    id_cuenta  BIGINT         NOT NULL,
    id_partida BIGINT         NOT NULL,
    FOREIGN KEY (id_cuenta) REFERENCES cuentas (id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_partida) REFERENCES partidas (id) ON UPDATE CASCADE ON DELETE CASCADE
);
