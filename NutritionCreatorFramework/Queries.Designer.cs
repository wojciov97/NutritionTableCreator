﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NutritionCreatorFramework {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Queries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Queries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NutritionCreatorFramework.Queries", typeof(Queries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Produkty (Produkt_Nazwa) VALUES (@ProductValue)  SELECT SCOPE_IDENTITY() AS &apos;NEWID&apos;.
        /// </summary>
        internal static string AddProduct {
            get {
                return ResourceManager.GetString("AddProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Receptury (Produkt_Id, Skladnik_Id, Ilosc, Jednostka_Id, Ilosc_Gotowa, JednostkaGotowa_Id)
        ///	VALUES(@PRODUCT_ID, (SELECT TOP 1 Skladnik_Id FROM Skladniki WHERE Skaldnik_Nazwa = @SKLADNIK_NAZWA), 
        ///	@COMPONENT_QUANTITY, @UNIT_ID, @TOTAL_MASS, @TOTAL_UNIT_ID).
        /// </summary>
        internal static string AddReciepe {
            get {
                return ResourceManager.GetString("AddReciepe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT pr.produkt_id AS PRID,
        ///       produkt_nazwa AS NAZWA,
        ///	   sk.Skladnik_Id AS SKLID,
        ///       sk.skaldnik_nazwa AS SKL_NAZWA,
        ///       re.ilosc AS ILOSC,
        ///       jeM.jednostka_id AS JID,
        ///       jeM.jednostka_mnoznik AS JMN,
        ///       jeM.jednostka_nazwa JNAME,
        ///       re.ilosc_gotowa AS QTY,
        ///       jeT.jednostka_id AS JMID,
        ///       jeT.jednostka_mnoznik JMMN,
        ///       jeT.jednostka_nazwa AS JMNAME
        ///FROM   produkty pr
        ///       JOIN receptury re
        ///         ON pr.produkt_id = re.produkt_id
        ///       JOIN sklad [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetProducts {
            get {
                return ResourceManager.GetString("GetProducts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Jednostka_Id, Jednostka_Nazwa, Jednostka_Mnoznik, Jednostka_IsLiquid FROM Jednostki ORDER BY Jednostka_IsLiquid, Jednostka_Mnoznik.
        /// </summary>
        internal static string GetUnits {
            get {
                return ResourceManager.GetString("GetUnits", resourceCulture);
            }
        }
    }
}
