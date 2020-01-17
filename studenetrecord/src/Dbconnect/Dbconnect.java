/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Dbconnect;

import java.sql.Connection;
import java.sql.DriverManager;

public class Dbconnect {
    public static Connection connect()
    {
        Connection db=null;
        
        try 
        {
            Class.forName("java.sql.Connection");
            db = DriverManager.getConnection("jdbc:mysql://localhost:3306/abc_student_system","root","");
            
            
        } 
        catch (Exception e) {
            System.out.println(e);
        }
        
        
        
        return db;
        
        
    
    
    }
}
