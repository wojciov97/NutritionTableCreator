﻿SELECT pr.produkt_id AS PRID,
       produkt_nazwa AS NAZWA,
	   sk.Skladnik_Id AS SKLID,
       sk.skaldnik_nazwa AS SKL_NAZWA,
       re.ilosc AS ILOSC,
       jeM.jednostka_id AS JID,
       jeM.jednostka_mnoznik AS JMN,
       jeM.jednostka_nazwa JNAME,
       re.ilosc_gotowa AS QTY,
       jeT.jednostka_id AS JMID,
       jeT.jednostka_mnoznik JMMN,
       jeT.jednostka_nazwa AS JMNAME
FROM   produkty pr
       JOIN receptury re
         ON pr.produkt_id = re.produkt_id
       JOIN skladniki sk
         ON re.skladnik_id = sk.skladnik_id
       JOIN jednostki jeM
         ON re.jednostka_id = jeM.jednostka_id
       JOIN jednostki jeT
         ON re.jednostkagotowa_id = jeT.jednostka_id 

ORDER BY pr.Produkt_Id