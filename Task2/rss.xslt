<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:ts="http://library.by/catalog">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/ts:catalog">
    <rss version="2.0">
      <channel>
        <title>Library</title>
        <link>http://library.by/catalog</link>
        <description>Best library yep ta</description>
        <xsl:apply-templates select="./ts:book" />
      </channel>
    </rss>

  </xsl:template>

  <xsl:template match="//ts:book">
    <item>
      <title>
        <xsl:value-of select="./ts:title"/>
      </title>
      <link>
        <xsl:if test="(./ts:genre = 'Computer') and (./ts:isbn)">
          <xsl:text>http://my.safaribooksonline.com/</xsl:text><xsl:value-of select="./ts:isbn"/><xsl:text>/</xsl:text>
        </xsl:if>
      </link>
      <description>
        <xsl:value-of select="./ts:description"/>
      </description>
      <pubDate>
        <xsl:value-of select="./ts:registration_date"/>
      </pubDate>
    </item>
  </xsl:template>
</xsl:stylesheet>
