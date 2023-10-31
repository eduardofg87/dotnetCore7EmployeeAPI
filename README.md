# dotnetCore7EmployeeAPI
Dotnet Core 7 Employee API

# Script DataBase

```
CREATE SEQUENCE public.employee_id_seq INCREMENT 1 MINVALUE 1;
CREATE TABLE IF NOT EXISTS public.employee
(
    id bigint NOT NULL DEFAULT nextval('employee_id_seq'::regclass),
    name character varying(255) COLLATE pg_catalog."default",
    age integer,
    photo character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT employee_pkey PRIMARY KEY (id)
)
```