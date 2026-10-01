# Práctica de Scripts e Introducción a Unity

Este repositorio contiene la resolución de los ejercicios correspondientes a los hitos de introducción a la programación de scripts en C# con Unity, abordando el manejo de componentes, vectores, transformaciones y referencias dinámicas.

---

## Hitos Relevantes de la Práctica

A continuación se detallan los aspectos clave y la lógica implementada en cada uno de los ejercicios realizados.

---

### Ejercicio 1: Modificación Dinámica de Vector de Color

**Descripción:**
Implementación de un script asociado a un objeto en escena que controla y modifica sus propiedades cromáticas de forma periódica e interactiva.

**Hitos y Lógica Implementada:**
* **Inicialización:** Se genera un `Vector3` donde cada una de sus componentes ($x, y, z$) toma valores aleatorios normalizados entre `0.0f` y `1.0f` mediante `Random.Range()`.
* **Parametrización:** Se expone la variable `framesToWait` en el Inspector de Unity para permitir la configuración flexible del intervalo de actualización sin necesidad de recompilar.
* **Modificación Parcial Aleatoria:** Cada ciclo de frames completado, se selecciona un único índice aleatorio ($0$, $1$ o $2$) para modificar únicamente esa componente dentro del vector.
* **Aplicación al Material:** Se convierte la estructura `Vector3` en un objeto de tipo `Color` y se asigna al material mediante la referencia de su `Renderer`.

![Demostración Ejercicio 1](media/ejercicio1.gif)

---

### Ejercicio 2: Operaciones y Relaciones entre Vectores 3D

**Descripción:**
Script asociado a un GameObject tipo Esfera para realizar cálculos algebraicos en espacio tridimensional basados en entradas configurables desde el Inspector.

**Hitos y Lógica Implementada:**
* **Entradas Paramétricas:** Definición de dos variables públicas de tipo `Vector3` (`vectorA` y `vectorB`) editables en tiempo real.
* **Cálculos Vectores:** 
  * Cálculo de magnitudes mediante `.magnitude`.
  * Cálculo del ángulo entre ambos vectores en grados con `Vector3.Angle()`.
  * Obtención de la distancia euclídea mediante `Vector3.Distance()`.
* **Comparación Espacial:** Comparación del eje $Y$ para determinar cuál de los dos vectores se encuentra a una cota de altura superior.
* **Detección de Cambios en Tiempo Real:** Evaluación continua en `Update()` que únicamente ejecuta el re-cálculo e imprime en consola cuando se detecta una variación respecto al frame anterior.

![Demostración Ejercicio 2](media/ejercicio2.gif)

---

### Ejercicio 3: Lectura y Proyección Visual de la Posición (`Transform`)

**Descripción:**
Obtención de las coordenadas del objeto en el mundo 3D y su representación visual en pantalla sobre la propia escena.

**Hitos y Lógica Implementada:**
* **Acceso a Componentes:** Recuperación directa de la propiedad `transform.position` del GameObject al que va asociado el script.
* **Integración con UI / TextMeshPro:** Uso de referencias a componentes `TMP_Text` serializadas (`[SerializeField]`) para desacoplar el script de la interfaz.
* **Formateo de Cadenas:** Interpolación de texto para formatear las coordenadas flotantes a dos decimales (`F2`), actualizando el bocadillo de texto dinámicamente cuando el objeto se desplaza.

![Demostración Ejercicio 3](media/ejercicio3.gif)

---

### Ejercicio 4: Búsqueda por Etiqueta y Medición de Distancias Relativas

**Descripción:**
Script de supervisión espacial que localiza otros GameObjects en la escena mediante etiquetas (*Tags*) para medir la distancia relativa entre ellos.

**Hitos y Lógica Implementada:**
* **Búsqueda Dinámica por Tag:** Uso de `GameObject.FindWithTag()` durante el `Start()` para localizar las referencias del Cubo y el Cilindro en la jerarquía sin necesidad de enlazarlas manualmente en el editor.
* **Cálculo de Distancia Multiobjeto:** Medición continua de distancias entre el punto de origen (Esfera) y las posiciones de los objetos encontrados.
* **Optimización de Mensajes en Consola:** Control de estado que compara la posición actual de los tres objetos involucrados respecto al frame anterior, imprimiendo el reporte en la consola exclusivamente cuando alguno de ellos cambia de posición.

![Demostración Ejercicio 4](media/ejercicio4.gif)

---

## Estructura de Entregables del Repositorio

```text
/
├── Scripts/
│   ├── ScriptEjercicio1.cs
│   ├── ScriptEjercicio2.cs
│   ├── ScriptEjercicio3.cs
│   └── ScriptEjercicio4.cs
├── media/
│   ├── ejercicio1.gif
│   ├── ejercicio2.gif
│   ├── ejercicio3.gif
│   └── ejercicio4.gif
└── Readme.md