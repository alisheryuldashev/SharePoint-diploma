Exercise 1: Generate an XML file from the XML DTD below –

<!ELEMENT collection (description,recipe*)>
<!ELEMENT description #PCDATA> <!ELEMENT recipe (title,ingredients*,preparation,comment?,nutrition)>
<!ELEMENT title (#PCDATA)>
<!ELEMENT ingredient (ingredients*,preparation)?>
<!ATTLIST ingredient name CDATA #REQUIRED
amount CDATA #IMPLIED
unit CDATA #IMPLIED>
<!ELEMENT preparation (step*)>
<!ELEMENT step (#PCDATA)>
<!ELEMENT comment (#PCDATA)>
<!ELEMENT nutrition EMPTY>
<!ATTLIST nutrition protein CDATA #REQUIRED
carbohydrates CDATA #REQUIRED
fat CDATA #REQUIRED
calories CDATA #REQUIRED
alcohol CDATA #IMPLIED>
