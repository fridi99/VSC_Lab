## Laborabgabe von Gruppe: Sigl, Rohland und Aslami

Unsere Abgabe besteht aus drei Projects. 
"Simulation" regelt die Energieverbrauhcssimulation
"Consumer" nutzt Rabbitmq um Simulationsdaten in der MongoDB zu speichern
"IO.Swagger" implementiert das API Interface

Am besten laufen alle Projekte geleichzeitig. Grobe Informationen zu:

**Simulation**: Das Projekt enthält einen SimulationManager der mehrere Meters verwaltet. Diese haben einen Zeitabhängigen stromverbrauch und Produktion und werden durch DateTime Objekte ausgelesen. Einfachheitshalber ist nur eine Instanz jeder Klasse im SimulationManager, aber man könnte beliebig viele hinzufügen. Der SimulationManager schickt über RabbitMQ die Smartmeter Daten an ein Topic.
Die Daten sind in folgendem Format aufgebaut:
- *meteringPointNumber*: Identifikationsnummer des Smartmeters
- *meterReading*: Stromverbrauchswert zum Zeitpunkt des Auslesens
- *operatingState*: Statusausgabe des Smartmeters
    - 0: Unknown
    - 1: Ok
    - 2: Maintainance
    - 3: Error
- *timestamp*: Zeitpunkt der Messung

**Consumer**: Der Consumer holt die Daten aus der RabbitMQ-Queue "SmartMeter" ab und schickt sie in die MongoDB-Collection "meteringPoints" in der Datenbank "my_database".

**IO.Swagger** implementiert ein Simples API Interface. Beim starten des Servers wird der Index im Browser geöffnet. Nur die Get Methoden wurden implementiert, da es schlecht für die Datenintegrität wäre, wenn man die Messwerte extern ändern könnte.
