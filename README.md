# ToDoAspNet
Postgres, Mono, EF, C#
Create PG Script:
DB Name : ToDoApp
DB SCRIPTS

-- Database: "ToDoApp"

-- DROP DATABASE "ToDoApp";

CREATE DATABASE "ToDoApp"
  WITH OWNER = postgres
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'en_US.UTF-8'
       LC_CTYPE = 'en_US.UTF-8'
       CONNECTION LIMIT = -1;

-- Table: "Items"

-- DROP TABLE "Items";

CREATE TABLE "Items"
(
  "ItemId" bigserial NOT NULL,
  "Name" text,
  "Description" text,
  "CompletedOn" date,
  "CreatedOn" date,
  CONSTRAINT "Items_pkey" PRIMARY KEY ("ItemId")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Items"
  OWNER TO postgres;
