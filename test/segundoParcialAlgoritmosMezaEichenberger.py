import statistics
print("Coloque las 6 notas del alumno por favor")
nota1 = int(input(("ingrese la 1er nota del alumno ")))
nota2 = int(input(("ingrese la 2da nota del alumno ")))
nota3 = int(input(("ingrese la 3ra nota del alumno ")))
nota4 = int(input(("ingrese la 4ta nota del alumno ")))
nota5 = int(input(("ingrese la 5ta nota del alumno ")))
nota6 = int(input(("ingrese la 6ta nota del alumno ")))
notas = 0
def maxMin(notas):
    return notas
notas = [nota1, nota2, nota3, nota4, nota5, nota6]
print("La nota mas alta del alumno es ", max(notas))  
print("La nota mas baja del alumno es ", min(notas)) 

promedio = statistics.mean(notas)
print("El promedio de las notas es ", promedio)