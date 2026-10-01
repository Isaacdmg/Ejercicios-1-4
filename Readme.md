# Práctica de scripts e introducción a Unity

Este repositorio contiene la resolución de los ejercicios correspondientes a los hitos de introducción a la programación de scripts en C# con Unity, abordando el manejo de componentes, vectores, transformaciones y referencias dinámicas.

---

### Ejercicio 1: Modificación dinámica de vector de color

**Descripción:**
Implementación de un script asociado a un objeto en escena que controla y modifica sus propiedades cromáticas de forma periódica e interactiva.

**Hitos y lógica implementada:**
* **Inicialización:** Se genera un `Vector3` donde cada una de sus componentes ($x, y, z$) toma valores aleatorios normalizados entre `0.0f` y `1.0f` mediante `Random.Range()`.
* **Parametrización:** Se expone la variable `framesToWait` en el Inspector de Unity para permitir la configuración flexible del intervalo de actualización sin necesidad de recompilar.
* **Modificación parcial aleatoria:** Cada ciclo de frames completado, se selecciona un único índice aleatorio ($0$, $1$ o $2$) para modificar únicamente esa componente dentro del vector.
* **Aplicación al material:** Se convierte la estructura `Vector3` en un objeto de tipo `Color` y se asigna al material mediante la referencia de su `Renderer`.

![Demostración ejercicio 1](media/Ejercicio1.gif)

---

### Ejercicio 2: Operaciones y relaciones entre vectores 3D

**Descripción:**
Script asociado a un GameObject tipo esfera para realizar cálculos algebraicos en espacio tridimensional basados en entradas configurables desde el inspector.

**Hitos y lógica implementada:**
* **Entradas paramétricas:** Definición de dos variables públicas de tipo `Vector3` (`myVector1` y `myVector2`) editables en tiempo real.
* **Cálculos vectores:** 
  * Cálculo de magnitudes mediante `.magnitude`.
  * Cálculo del ángulo entre ambos vectores en grados con `Vector3.Angle()`.
  * Obtención de la distancia euclídea mediante `Vector3.Distance()`.
* **Comparación espacial:** Comparación del eje $Y$ para determinar cuál de los dos vectores se encuentra a una cota de altura superior.
* **Detección de cambios en tiempo real:** Evaluación continua en `Update()` que únicamente ejecuta el re-cálculo e imprime en consola cuando se detecta una variación respecto al frame anterior.

![Demostración ejercicio 2](media/Ejercicio2.gif)

---

### Ejercicio 3: Lectura y proyección visual de la posición (`Transform`)

**Descripción:**
Obtención de las coordenadas del objeto en el mundo 3D y su representación visual en pantalla sobre la propia escena.

**Hitos y lógica implementada:**
* **Acceso a componentes:** Recuperación directa de la propiedad `transform.position` del GameObject al que va asociado el script.
* **Integración con UI / TextMeshPro:** Uso de referencias a componentes `TMP_Text` para mostrar texto en pantalla.
* **Formateo de cadenas:** Interpolación de texto para formatear las coordenadas flotantes a dos decimales (`F2`), actualizando el bocadillo de texto dinámicamente cuando el objeto se desplaza.

![Demostración ejercicio 3](media/Ejercicio3.gif)

---

### Ejercicio 4: Búsqueda por etiqueta y medición de distancias relativas

**Descripción:**
Script de supervisión espacial que localiza otros GameObjects en la escena mediante etiquetas (*Tags*) para medir la distancia relativa entre ellos.

**Hitos y lógica implementada:**
* **Búsqueda dinámica por tag:** Uso de `GameObject.FindGameObjectWithTag()` durante el `Start()` para localizar las referencias del cubo y el cilindro en la jerarquía sin necesidad de enlazarlas manualmente en el editor.
* **Cálculo de distancia multiobjeto:** Medición continua de distancias entre el punto de origen (esfera) y las posiciones de los objetos encontrados.
* **Optimización de mensajes en consola:** Control de estado que compara la posición actual de los tres objetos involucrados respecto al frame anterior, imprimiendo el reporte en la consola exclusivamente cuando alguno de ellos cambia de posición.

![Demostración ejercicio 4](media/Ejercicio4.gif)

---

## Estructura de entregables del repositorio

```text
/
├── Assets/
│   ├──Scripts/
|      ├── Ejercicio1/
│      ├── Ejercicio2/
│      ├── Ejercicio3/
│      └── Ejercicio4/
├── media/
│   ├── ejercicio1.gif
│   ├── ejercicio2.gif
│   ├── ejercicio3.gif
│   └── ejercicio4.gif
└── Readme.md
