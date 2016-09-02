 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h e   S e a G r i d A d a p t e r   a l l o w s   f o r   t h e   c h a n g e   i n   a   s e a   g r i d   v i e w .   W h e n e v e r   a   s h i p   i s  
 / / /   p r e s e n t e d   i t   c h a n g e s   t h e   v i e w   i n t o   a   s e a   t i l e   i n s t e a d   o f   a   s h i p   t i l e .  
 / / /   < / s u m m a r y >  
 p u b l i c   c l a s s   S e a G r i d A d a p t e r   :   I S e a G r i d  
 {  
  
  
 	 p r i v a t e   S e a G r i d   _ M y G r i d ;  
 	 / / /   < s u m m a r y >  
 	 / / /   C r e a t e   t h e   S e a G r i d A d a p t e r ,   w i t h   t h e   g r i d ,   a n d   i t   w i l l   a l l o w   i t   t o   b e   c h a n g e d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " g r i d " > t h e   g r i d   t h a t   n e e d s   t o   b e   a d a p t e d < / p a r a m >  
 	 p u b l i c   S e a G r i d A d a p t e r ( S e a G r i d   g r i d )  
 	 {  
 	 	 _ M y G r i d   =   g r i d ;  
 	 	 _ M y G r i d . C h a n g e d   + =   n e w   E v e n t H a n d l e r ( M y G r i d _ C h a n g e d ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   M y G r i d _ C h a n g e d   c a u s e s   t h e   g r i d   t o   b e   r e d r a w n   b y   r a i s i n g   a   c h a n g e d   e v e n t  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s e n d e r " > t h e   o b j e c t   t h a t   c a u s e d   t h e   c h a n g e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " e " > w h a t   n e e d s   t o   b e   r e d r a w n < / p a r a m >  
 	 p r i v a t e   v o i d   M y G r i d _ C h a n g e d ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
 	 {  
 	 	 i f   ( C h a n g e d   ! =   n u l l )   {  
 	 	 	 C h a n g e d ( t h i s ,   e ) ;  
 	 	 }  
 	 }  
  
 	 # r e g i o n   " I S e a G r i d   M e m b e r s "  
  
 	 / / /   < s u m m a r y >  
 	 / / /   C h a n g e s   t h e   d i s c o v e r y   g r i d .   W h e r e   t h e r e   i s   a   s h i p   w e   w i l l   s e a   w a t e r  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " x " > t i l e   x   c o o r d i n a t e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " y " > t i l e   y   c o o r d i n a t e < / p a r a m >  
 	 / / /   < r e t u r n s > a   t i l e ,   e i t h e r   w h a t   i t   a c t u a l l y   i s ,   o r   i f   i t   w a s   a   s h i p   t h e n   r e t u r n   a   s e a   t i l e < / r e t u r n s >  
 	 p u b l i c   T i l e V i e w   I t e m   {  
 	 	 g e t   {  
 	 	 	 T i l e V i e w   r e s u l t   =   _ M y G r i d . I t e m ( x ,   y ) ;  
  
 	 	 	 i f   ( r e s u l t   = =   T i l e V i e w . S h i p )   {  
 	 	 	 	 r e t u r n   T i l e V i e w . S e a ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 r e t u r n   r e s u l t ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   I n d i c a t e s   t h a t   t h e   g r i d   h a s   b e e n   c h a n g e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   e v e n t   E v e n t H a n d l e r   I S e a G r i d . C h a n g e d ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t   t h e   w i d t h   o f   a   t i l e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   i n t   W i d t h   {  
 	 	 g e t   {   r e t u r n   _ M y G r i d . W i d t h ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t   t h e   h e i g h t   o f   t h e   t i l e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   i n t   H e i g h t   {  
 	 	 g e t   {   r e t u r n   _ M y G r i d . H e i g h t ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H i t T i l e   c a l l s   o p p o n   _ M y G r i d   t o   h i t   a   t i l e   a t   t h e   r o w ,   c o l  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   i t s   h i t t i n g   a t < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   i t s   h i t t i n g   a t < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   r e s u l t   f r o m   h i t t i n g   t h a t   t i l e < / r e t u r n s >  
 	 p u b l i c   A t t a c k R e s u l t   H i t T i l e ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 r e t u r n   _ M y G r i d . H i t T i l e ( r o w ,   c o l ) ;  
 	 }  
 	 # e n d r e g i o n  
  
 }  
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
  
 