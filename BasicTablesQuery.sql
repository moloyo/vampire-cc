Select c.Nombre, c.Descripcion, d1.Nombre, d2.Nombre, d3.Nombre
from Clan c
inner join Disciplina d1
on c.Disciplina1_ID = d1.ID
inner join Disciplina d2
on c.Disciplina2_ID = d2.ID
inner join Disciplina d3
on c.Disciplina3_ID = d3.ID
