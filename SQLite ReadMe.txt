Changing paths in .bat file:
cd "%~dp0\" points to the current directory (do not change!)
After sqlite3 you must change the path to project folder, then the Data folder & finally the .db file (SQLite database)

To run program:
Double click on .bat file

Commands to use in program:
show all available commands: .help
dump the database in SQL text format: .dump
show table in current database: .tables
show the structure of all tables: .schema
show structure of a table: .schema TABLE
exit sqlite3 program: .exit

