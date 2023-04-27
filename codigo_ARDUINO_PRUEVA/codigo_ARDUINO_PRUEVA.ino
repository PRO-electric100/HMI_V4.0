void setup() {
  Serial.begin(38400);
}
float a=0.1;
float b=0.5;
float c=0.2;
float d=0.2;
float e=0.2;
float x=0.6;
float y=0.6;
float gr= PI/180;
void loop() {
  a++;
  b++;
  c++;
  d++;
  e++;
  x++;
  y++;
  String s ='$'+String(sin(gr*a))+';'+String(sin(gr*b))+';'+String(sin(gr*c))+';'+String(10*sin(gr*d))+';'+String(10*sin(gr*e))+';'+String(sin(gr*x))+';'+String(sin(gr*y));
  Serial.println(s);
  delay(1000);
}
