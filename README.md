# 🐸 README: THE DEPTHS - Prototipo Jugable (MVP)

## 🌟 Resumen del Proyecto

**THE DEPTHS** es un Metroidvania de ambiente oscuro, gótico y mecanizado. El jugador, un anfibio cíborg, desciende a las ruinas de una civilización perdida en busca de la luz.

**Objetivo para el MVP (2.5 Meses):** Crear un **Demo Jugable de Alcance Limitado** que pruebe las mecánicas centrales de movimiento, combate y progresión, y establezca la atmósfera visual del juego.

**Alcance para el MVP (Clave para la Realidad en 10 Semanas):**
1.  **Un Único Nivel (Mini-Nivel):** La primera sección de **"La Superficie Rota"** (aproximadamente 3 a 5 pantallas conectadas).
2.  **Un Único *Upgrade* Esencial:** Solo el Doble Salto (**Propulsores Residuales**).
3.  **Un Único Enemigo Funcional:** Solo el **Escarabajo-Chapa**.
4.  **No Boss:** El demo termina al obtener el *upgrade* o al final del mini-nivel.

---

## 🗺️ Roadmap de 10 Semanas (MVP Estratégico)

El plan se divide en 3 fases: **Fundación (Arquitectura)**, **Integración (Contenido)** y **Pulido (Arte y Experiencia)**.

### 📌 Fase 1: Fundación y Prototipado (Semanas 1-3)
* **Foco:** Establecer la arquitectura MVC/Componentes, movimiento básico y arte de prueba.

| Hito                    | Tarea Principal                                                                                                  | Semanas |
| :---------------------- | :--------------------------------------------------------------------------------------------------------------- | :------ |
| **Arquitectura**        | Implementación de la estructura de carpetas MVC + Componentes. Clases `PlayerSheet` y `PlayerControl`.           | 1       |
| **Movimiento Básico**   | Implementación de `CharacterBody2D` y `Player.cs`. Movimiento de caminar y fricción.                             | 1       |
| **Mecánica de Combate** | Ataque cuerpo a cuerpo base (Espada de Luz). Detección de *Hitbox* y `HealthComponent`.                          | 2       |
| **Arte de Prueba**      | Diseño del Protagonista base (sapo cíborg) y animación *Idle* y *Run*. Un *Tileset* simple para las paredes.     | 2-3     |
| **Integración MVC**     | Conectar `PlayerControl` para manipular la `Velocity` del `CharacterBody2D` usando `WalkSpeed` de `PlayerSheet`. | 3       |

### 📌 Fase 2: Integración y Contenido (Semanas 4-7)
* **Foco:** Construir el nivel de demostración, introducir el *upgrade* y el enemigo.

| Hito                           | Tarea Principal                                                                                       | Semanas |
| :----------------------------- | :---------------------------------------------------------------------------------------------------- | :------ |
| **Diseño de Nivel**            | Diseño y maquetación del mini-nivel **"La Superficie Rota"** (5 pantallas).                           | 4       |
| **Implementación del Upgrade** | Crear el componente de Doble Salto (**Propulsores Residuales**) y la lógica de adquisición.           | 4       |
| **Enemigo Base**               | Diseño de arte y animaciones del **Escarabajo-Chapa**. Implementación de `EnemyAI` básica (patrulla). | 5       |
| **Combate Real**               | Ajuste de daño, salud y retroceso. Interacción del jugador y enemigo con `HealthComponent`.           | 6       |
| **Interacción**                | Puntos de guardado y Checkpoint funcionales.                                                          | 7       |

### 📌 Fase 3: Pulido y Publicación del Demo (Semanas 8-10)
* **Foco:** Refinar la sensación, el arte final y preparar el demo para mostrar.

| Hito                | Tarea Principal                                                                                                   | Semanas |
| :------------------ | :---------------------------------------------------------------------------------------------------------------- | :------ |
| **Arte Final**      | Reemplazo del *Tileset* de prueba por el arte final (Gótico/Mecanizado). Implementación de *Parallax*.            | 8       |
| **Audio y VFX**     | Sonidos básicos (salto, ataque, daño, música de fondo de ambiente). Efectos visuales (bioluminiscencia, chispas). | 9       |
| **HUD**             | Interfaz de Usuario simple (Vida, Estamina) conectada al `HealthComponent` y `PlayerSheet`.                       | 9       |
| **Pulido y Testeo** | Corrección de *bugs* del nivel, ajustes de *Game Feel* (animación, velocidad, peso).                              | 10      |
| **Lanzamiento**     | Exportación del juego y preparación de documentación. **¡MVP Terminado!**                                         | 10      |

---

## 🗓️ Diagrama de Gantt (10 Semanas)

El tiempo dedicado a cada tarea se representa con **`X`**.

| Tarea (Resumen)               | Sem. 1   | Sem. 2   | Sem. 3 | Sem. 4   | Sem. 5   | Sem. 6   | Sem. 7 | Sem. 8   | Sem. 9   | Sem. 10  |
| :---------------------------- | :------- | :------- | :----- | :------- | :------- | :------- | :----- | :------- | :------- | :------- |
| **FASE 1: FUNDACIÓN**         |          |          |        |          |          |          |        |          |          |          |
| 1.1 Arquitectura (MVC)        | **XXXX** |          |        |          |          |          |        |          |          |          |
| 1.2 Movimiento Básico         | **XXXX** |          |        |          |          |          |        |          |          |          |
| 1.3 Combate Base (Ataque)     |          | **XXXX** |        |          |          |          |        |          |          |          |
| 1.4 Arte de Prueba & Anim.    |          | **XXXX** | **XX** |          |          |          |        |          |          |          |
| **FASE 2: INTEGRACIÓN**       |          |          |        |          |          |          |        |          |          |          |
| 2.1 Diseño/Maquetación Nivel  |          |          | **XX** | **XXXX** |          |          |        |          |          |          |
| 2.2 Implementación Upgrade    |          |          |        | **XXXX** |          |          |        |          |          |          |
| 2.3 Enemigo Base (Escarabajo) |          |          |        |          | **XXXX** |          |        |          |          |          |
| 2.4 Combate/Health Comp.      |          |          |        |          | **XX**   | **XXXX** |        |          |          |          |
| 2.5 Puntos de Interacción     |          |          |        |          |          | **XX**   | **XX** |          |          |          |
| **FASE 3: PULIDO DEMO**       |          |          |        |          |          |          |        |          |          |          |
| 3.1 Arte Final de Nivel       |          |          |        |          |          |          |        | **XXXX** |          |          |
| 3.2 Audio y VFX               |          |          |        |          |          |          |        | **XX**   | **XXXX** |          |
| 3.3 HUD (UI)                  |          |          |        |          |          |          |        |          | **XX**   |          |
| 3.4 Pulido y Testeo           |          |          |        |          |          |          |        |          | **XX**   | **XXXX** |
| 3.5 Exportación (MVP)         |          |          |        |          |          |          |        |          |          | **XX**   |