 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h e   I S e a G r i d   d e f i n e s   t h e   r e a d   o n l y   i n t e r f a c e   o f   a   G r i d .   T h i s  
 / / /   a l l o w s   e a c h   p l a y e r   t o   s e e   a n d   a t t a c k   t h e i r   o p p o n e n t s   g r i d .  
 / / /   < / s u m m a r y >  
namespace BattleShips
{
 p u b l i c   i n t e r f a c e   I S e a G r i d  
 {  
  
  
 	 i n t   W i d t h   {   g e t ;   }  
  
 	 i n t   H e i g h t   {   g e t ;   }  
 	 / / /   < s u m m a r y >  
 	 / / /   I n d i c a t e s   t h a t   t h e   g r i d   h a s   c h a n g e d .  
 	 / / /   < / s u m m a r y >  
  
 	 e v e n t   E v e n t H a n d l e r   C h a n g e d ;  
 	 / / /   < s u m m a r y >  
 	 / / /   P r o v i d e s   a c c e s s   t o   t h e   g i v e n   r o w / c o l u m n  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   t o   a c c e s s < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   t o   a c c e s s < / p a r a m >  
 	 / / /   < v a l u e > w h a t   t h e   p l a y e r   c a n   s e e   a t   t h a t   l o c a t i o n < / v a l u e >  
 	 / / /   < r e t u r n s > w h a t   t h e   p l a y e r   c a n   s e e   a t   t h a t   l o c a t i o n < / r e t u r n s >  
  
 	 T i l e V i e w   I t e m   {   g e t ;   }  
 	 / / /   < s u m m a r y >  
 	 / / /   M a r k   t h e   i n d i c a t e d   t i l e   a s   s h o t .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   o f   t h e   t i l e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   o f   t h e   t i l e < / p a r a m >  
 	 / / /   < r e t u r n s > t h e   r e s u l t   o f   t h e   a t t a c k < / r e t u r n s >  
 	 A t t a c k R e s u l t   H i t T i l e ( i n t   r o w ,   i n t   c o l ) ;  
 } } 
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
  
 
