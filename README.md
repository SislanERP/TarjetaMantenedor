# TarjetaMantenedor
Programa para administrar usuarios BioStar.

El programa para administrar los usuarios del sistema BioStar tiene las siguientes funcionalidades:

1.- Agregar nuevos usuario y asignarles una tarjeta (la tarjeta debe ser agregada por su número identificador), 
por defecto los usuarios se crean activos.
2.- Editar usuarios (cambiar su nombre, su id, su número de tarjeta y el grupo de acceso).
3.- Activar usuarios (permite activar un usuario desactivado, otorgandole paso por los accesos designados a través 
del grupo de acceso al que pertenece).
4.- Desactivar usuarios (permite desactivar usuarios, negandoles totalmente el paso)

El programa cuenta con roles y perfiles para administrar los usuarios de este programa.

Cada usuario del programa debe tener asignado un rol, este rol puede tener asignados varios perfiles y a su vez, 
cada perfil puede tener varios recursos asignados.

Los recursos establecidos en el programa son las funcionalidades antes descritas (agregar, editar, activar y desactivar), 
se considera un recurso al formulario que muestra a los usuarios del sistema BioStar.

Por lo tanto existen 5 recursos que deben ser asignados.
