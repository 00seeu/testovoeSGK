SELECT    id,  userid, status
from tz_db
where userid = 85 
and 
id = (select max(status)
from tz_db);

