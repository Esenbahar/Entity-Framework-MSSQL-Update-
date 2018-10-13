"# Entity-Framework-MSSQL-Update-" 

Linq, programcı açısından ADO.NET ile uzun uzadıya kod yazmaya son verir ve veriye kolayca erişebilmeyi sağlar. ADO.NET yapısı kullanıldığında hatalar çalışma zamanında ortaya çıkarken, linq teknolojisi kullanıldığında hatalar derleme zamanında ortaya çıkar. Fark edilen hatalar direkt olarak karşımıza çıkar ve hatayı önceden görmemiz programın düzeltmelerini erkenden yapmamızı sağlar.

ADO.NET’te veri çekmek için connectionstring, sqlcommand, dataset, bağlantıyı açma kapama gibi işlemler yapmak zorundayız. Bunları yaparken de fazla kod yazmak gerekiyor. Linq’da değişiklik neredeyse hiç yapılmamakta ve veritabanına ulaşırken bağlantının açık kapalı olmasını kontrol etmeye gerek kalmamaktadır.

Linq to Sql ile yazdığımız sorgular ADO.NET sorgusu haline dönüştürülüyor ve sorgu gerçekleşiyor. Yani, yazdıklarımız birer veri tabanı sorgusu haline dönüştürülüp gerçekleştiriliyor. Arkada koşan işlem bir ADO.NET yapısı olduğundan performans açısından ikisi de neredeyse aynıdır.
