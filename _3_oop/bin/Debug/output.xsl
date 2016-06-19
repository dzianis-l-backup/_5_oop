<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="root">
  <HTML>
    <BODY>
      <TABLE BORDER="2">
        <TR>
          <TD>Name</TD>
          <TD>Age</TD>
          <TD>CanFly</TD>
		  <TD>WingsQuantity</TD>
        </TR>
        <xsl:apply-templates select="JsonConv"/>
      </TABLE>
    </BODY>
  </HTML>
</xsl:template>
<xsl:template match="JsonConv">
  <TR>
   
    <TD><xsl:value-of select="Name"/></TD>
	<TD><xsl:value-of select="Age"/></TD>
    <TD><xsl:value-of select="CanFly"/></TD>
	<TD><xsl:value-of select="WingsQuantity"/></TD>
	
  </TR>
</xsl:template>

</xsl:stylesheet>