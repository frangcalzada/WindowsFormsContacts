using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Esta clase representa la tabla o grilla de contactos y voy a recrear los datos de la bd
 * con el comando prop y 2 veces tab se crear un snippet de entidad de bd
*/

namespace WindowsFormsContacts
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
