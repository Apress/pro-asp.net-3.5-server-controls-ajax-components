<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
  <xsl:template match="/">
    <table>
      <th>Title</th>
      <th>Author</th>
      <th>ISBN</th>
      <th>Date Published</th>
      <xsl:for-each select='//Books'>
        <xsl:choose>
          <xsl:when test="position() mod 2 = 1">
            <tr bgcolor="Silver">
              <td>
                <xsl:value-of select='Title' />
              </td>
              <td>
                <xsl:value-of select='Author' />
              </td>
              <td>
                <xsl:value-of select='ISBN' />
              </td>
              <td>
                <xsl:value-of select='DatePublished' />
              </td>
            </tr>
          </xsl:when>
          <xsl:otherwise>
            <tr bgcolor="White">
              <td>
                <xsl:value-of select='Title' />
              </td>
              <td>
                <xsl:value-of select='Author' />
              </td>
              <td>
                <xsl:value-of select='ISBN' />
              </td>
              <td>
                <xsl:value-of select='DatePublished' />
              </td>
            </tr>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>


