u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h e   B a t t l e S h i p s G a m e   c o n t r o l s   a   b i g   p a r t   o f   t h e   g a m e .   I t   w i l l   a d d   t h e   t w o   p l a y e r s  
 / / /   t o   t h e   g a m e   a n d   m a k e   s u r e   t h a t   b o t h   p l a y e r s   s h i p s   a r e   a l l   d e p l o y e d   b e f o r e   s t a r t i n g   t h e   g a m e .  
 / / /   I t   a l s o   a l l o w s   p l a y e r s   t o   s h o o t   a n d   s w a p   t u r n s   b e t w e e n   p l a y e r .   I t   w i l l   a l s o   c h e c k   i f   p l a y e r s    
 / / /   a r e   d e s t r o y e d .  
 / / /   < / s u m m a r y >  
 p u b l i c   c l a s s   B a t t l e S h i p s G a m e  
 {  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   a t t a c k   d e l e g a t e   t y p e   i s   u s e d   t o   s e n d   n o t i f i c a t i o n s   o f   t h e   e n d   o f   a n  
 	 / / /   a t t a c k   b y   a   p l a y e r   o r   t h e   A I .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s e n d e r " > t h e   g a m e   s e n d i n g   t h e   n o t i f i c a t i o n < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " r e s u l t " > t h e   r e s u l t   o f   t h e   a t t a c k < / p a r a m >  
 	 p u b l i c   d e l e g a t e   v o i d   A t t a c k C o m p l e t e d H a n d l e r ( o b j e c t   s e n d e r ,   A t t a c k R e s u l t   r e s u l t ) ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   A t t a c k C o m p l e t e d   e v e n t   i s   r a i s e d   w h e n   a n   a t t a c k   h a s   c o m p l e t e d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   T h i s   i s   u s e d   b y   t h e   U I   t o   p l a y   s o u n d   e f f e c t s   e t c .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   e v e n t   A t t a c k C o m p l e t e d H a n d l e r   A t t a c k C o m p l e t e d ;  
  
 	 p r i v a t e   P l a y e r [ ]   _ p l a y e r s   =   n e w   P l a y e r [ 3 ] ;  
  
 	 p r i v a t e   i n t   _ p l a y e r I n d e x   =   0 ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   c u r r e n t   p l a y e r .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   c u r r e n t   p l a y e r < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   c u r r e n t   p l a y e r < / r e t u r n s >  
 	 / / /   < r e m a r k s > T h i s   v a l u e   w i l l   s w i t c h   b e t w e e n   t h e   t w o   p l a y e r s   a s   t h e y   h a v e   t h e i r   a t t a c k s < / r e m a r k s >  
 	 p u b l i c   P l a y e r   P l a y e r   {  
 	 	 g e t   {   r e t u r n   _ p l a y e r s ( _ p l a y e r I n d e x ) ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A d d D e p l o y e d P l a y e r   a d d s   b o t h   p l a y e r s   a n d   w i l l   m a k e   s u r e  
 	 / / /   t h a t   t h e   A I   p l a y e r   d e p l o y s   a l l   s h i p s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " p " > < / p a r a m >  
 	 p u b l i c   v o i d   A d d D e p l o y e d P l a y e r ( P l a y e r   p )  
 	 {  
 	 	 i f   ( _ p l a y e r s ( 0 )   = =   n u l l )   {  
 	 	 	 _ p l a y e r s ( 0 )   =   p ;  
 	 	 }   e l s e   i f   ( _ p l a y e r s ( 1 )   = =   n u l l )   {  
 	 	 	 _ p l a y e r s ( 1 )   =   p ;  
 	 	 	 C o m p l e t e D e p l o y m e n t ( ) ;  
 	 	 }   e l s e   {  
 	 	 	 t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " Y o u   c a n n o t   a d d   a n o t h e r   p l a y e r ,   t h e   g a m e   a l r e a d y   h a s   t w o   p l a y e r s . " ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A s s i g n s   e a c h   p l a y e r   t h e   o t h e r ' s   g r i d   a s   t h e   e n e m y   g r i d .   T h i s   a l l o w s   e a c h   p l a y e r  
 	 / / /   t o   e x a m i n e   t h e   d e t a i l s   v i s a b l e   o n   t h e   o t h e r ' s   s e a   g r i d .  
 	 / / /   < / s u m m a r y >  
 	 p r i v a t e   v o i d   C o m p l e t e D e p l o y m e n t ( )  
 	 {  
 	 	 _ p l a y e r s ( 0 ) . E n e m y   =   n e w   S e a G r i d A d a p t e r ( _ p l a y e r s ( 1 ) . P l a y e r G r i d ) ;  
 	 	 _ p l a y e r s ( 1 ) . E n e m y   =   n e w   S e a G r i d A d a p t e r ( _ p l a y e r s ( 0 ) . P l a y e r G r i d ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h o o t   w i l l   s w a p   b e t w e e n   p l a y e r s   a n d   c h e c k   i f   a   p l a y e r   h a s   b e e n   k i l l e d .  
 	 / / /   I t   a l s o   a l l o w s   t h e   c u r r e n t   p l a y e r   t o   h i t   o n   t h e   e n e m y g r i d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   f i r e d   u p o n < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   f i r e d   u p o n < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   r e s u l t   o f   t h e   a t t a c k < / r e t u r n s >  
 	 p u b l i c   A t t a c k R e s u l t   S h o o t ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 A t t a c k R e s u l t   n e w A t t a c k   =   d e f a u l t ( A t t a c k R e s u l t ) ;  
 	 	 i n t   o t h e r P l a y e r   =   ( _ p l a y e r I n d e x   +   1 )   %   2 ;  
  
 	 	 n e w A t t a c k   =   P l a y e r . S h o o t ( r o w ,   c o l ) ;  
  
 	 	 / / W i l l   e x i t   t h e   g a m e   w h e n   a l l   p l a y e r s   s h i p s   a r e   d e s t r o y e d  
 	 	 i f   ( _ p l a y e r s ( o t h e r P l a y e r ) . I s D e s t r o y e d )   {  
 	 	 	 n e w A t t a c k   =   n e w   A t t a c k R e s u l t ( R e s u l t O f A t t a c k . G a m e O v e r ,   n e w A t t a c k . S h i p ,   n e w A t t a c k . T e x t ,   r o w ,   c o l ) ;  
 	 	 }  
  
 	 	 i f   ( A t t a c k C o m p l e t e d   ! =   n u l l )   {  
 	 	 	 A t t a c k C o m p l e t e d ( t h i s ,   n e w A t t a c k ) ;  
 	 	 }  
  
 	 	 / / c h a n g e   p l a y e r   i f   t h e   l a s t   h i t   w a s   a   m i s s  
 	 	 i f   ( n e w A t t a c k . V a l u e   = =   R e s u l t O f A t t a c k . M i s s )   {  
 	 	 	 _ p l a y e r I n d e x   =   o t h e r P l a y e r ;  
 	 	 }  
  
 	 	 r e t u r n   n e w A t t a c k ;  
 	 }  
 }  
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 