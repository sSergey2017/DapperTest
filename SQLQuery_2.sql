            SELECT 
                c.NameCat,
                o.NameOvner,
                e.DateExpo,
                e.City,
                e.Country
            from Cat c
            inner Join Owners o on o.id = c.ownerid
            inner Join Participants p on p.Catid = c.id
            inner Join Exposition e on e.id = p.ExpoId