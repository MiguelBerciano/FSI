       ЃK"	   ^ЁПжAbrain.Event:2!%ЮкУ     беd	Ц^ЁПжA"Э
v
(matching_filenames/MatchingFiles/patternConst*
valueB BTrain/0/*.jpg*
dtype0*
_output_shapes
: 

 matching_filenames/MatchingFilesMatchingFiles(matching_filenames/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
z
matching_filenames
VariableV2*
shared_name *
dtype0*
shape:*
_output_shapes
:*
	container 
з
matching_filenames/AssignAssignmatching_filenames matching_filenames/MatchingFiles*%
_class
loc:@matching_filenames*#
_output_shapes
:џџџџџџџџџ*
T0*
validate_shape( *
use_locking(

matching_filenames/readIdentitymatching_filenames*
T0*%
_class
loc:@matching_filenames*
_output_shapes
:
e
input_producer/SizeSizematching_filenames/read*
T0*
_output_shapes
: *
out_type0
Z
input_producer/Greater/yConst*
_output_shapes
: *
dtype0*
value	B : 
q
input_producer/GreaterGreaterinput_producer/Sizeinput_producer/Greater/y*
T0*
_output_shapes
: 

input_producer/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

#input_producer/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer/Assert/AssertAssertinput_producer/Greater#input_producer/Assert/Assert/data_0*

T
2*
	summarize
~
input_producer/IdentityIdentitymatching_filenames/read^input_producer/Assert/Assert*
_output_shapes
:*
T0

input_producerFIFOQueueV2*
shapes
: *
capacity *
	container *
shared_name *
_output_shapes
: *
component_types
2

)input_producer/input_producer_EnqueueManyQueueEnqueueManyV2input_producerinput_producer/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
b
#input_producer/input_producer_CloseQueueCloseV2input_producer*
cancel_pending_enqueues( 
d
%input_producer/input_producer_Close_1QueueCloseV2input_producer*
cancel_pending_enqueues(
Y
"input_producer/input_producer_SizeQueueSizeV2input_producer*
_output_shapes
: 
o
input_producer/CastCast"input_producer/input_producer_Size*
_output_shapes
: *

DstT0*

SrcT0
Y
input_producer/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *   =
e
input_producer/mulMulinput_producer/Castinput_producer/mul/y*
_output_shapes
: *
T0

'input_producer/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*3
value*B( B"input_producer/fraction_of_32_full

"input_producer/fraction_of_32_fullScalarSummary'input_producer/fraction_of_32_full/tagsinput_producer/mul*
_output_shapes
: *
T0
b
WholeFileReaderV2WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
Y
ReaderReadV2ReaderReadV2WholeFileReaderV2input_producer*
_output_shapes
: : 
ш

DecodeJpeg
DecodeJpegReaderReadV2:1*
acceptable_fraction%  ?*

dct_method *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
fancy_upscaling(*
channels *
try_recover_truncated( 
O
ShapeShape
DecodeJpeg*
out_type0*
_output_shapes
:*
T0
W
assert_positive/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
k
 assert_positive/assert_less/LessLessassert_positive/ConstShape*
T0*
_output_shapes
:
k
!assert_positive/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
 
assert_positive/assert_less/AllAll assert_positive/assert_less/Less!assert_positive/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

(assert_positive/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

0assert_positive/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ѓ
)assert_positive/assert_less/Assert/AssertAssertassert_positive/assert_less/All0assert_positive/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Н
control_dependencyIdentity
DecodeJpeg*^assert_positive/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
Y
Shape_1Shapecontrol_dependency*
T0*
out_type0*
_output_shapes
:
V
unstackUnpackShape_1*	
num*
T0*
_output_shapes
: : : *

axis 
H
sub/xConst*
value
B :*
_output_shapes
: *
dtype0
=
subSubsub/x	unstack:1*
T0*
_output_shapes
: 
0
NegNegsub*
T0*
_output_shapes
: 
L

floordiv/yConst*
value	B :*
_output_shapes
: *
dtype0
F
floordivFloorDivNeg
floordiv/y*
_output_shapes
: *
T0
K
	Maximum/yConst*
value	B : *
dtype0*
_output_shapes
: 
H
MaximumMaximumfloordiv	Maximum/y*
_output_shapes
: *
T0
N
floordiv_1/yConst*
dtype0*
_output_shapes
: *
value	B :
J

floordiv_1FloorDivsubfloordiv_1/y*
T0*
_output_shapes
: 
M
Maximum_1/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_1Maximum
floordiv_1Maximum_1/y*
_output_shapes
: *
T0
I
sub_1/xConst*
value	B :P*
dtype0*
_output_shapes
: 
?
sub_1Subsub_1/xunstack*
T0*
_output_shapes
: 
4
Neg_1Negsub_1*
T0*
_output_shapes
: 
N
floordiv_2/yConst*
value	B :*
_output_shapes
: *
dtype0
L

floordiv_2FloorDivNeg_1floordiv_2/y*
T0*
_output_shapes
: 
M
Maximum_2/yConst*
value	B : *
dtype0*
_output_shapes
: 
N
	Maximum_2Maximum
floordiv_2Maximum_2/y*
_output_shapes
: *
T0
N
floordiv_3/yConst*
_output_shapes
: *
dtype0*
value	B :
L

floordiv_3FloorDivsub_1floordiv_3/y*
T0*
_output_shapes
: 
M
Maximum_3/yConst*
dtype0*
_output_shapes
: *
value	B : 
N
	Maximum_3Maximum
floordiv_3Maximum_3/y*
_output_shapes
: *
T0
K
	Minimum/xConst*
_output_shapes
: *
dtype0*
value	B :P
G
MinimumMinimum	Minimum/xunstack*
_output_shapes
: *
T0
N
Minimum_1/xConst*
value
B :*
_output_shapes
: *
dtype0
M
	Minimum_1MinimumMinimum_1/x	unstack:1*
_output_shapes
: *
T0
Y
Shape_2Shapecontrol_dependency*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_1/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
q
"assert_positive_1/assert_less/LessLessassert_positive_1/ConstShape_2*
T0*
_output_shapes
:
m
#assert_positive_1/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_1/assert_less/AllAll"assert_positive_1/assert_less/Less#assert_positive_1/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_1/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_1/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Љ
+assert_positive_1/assert_less/Assert/AssertAssert!assert_positive_1/assert_less/All2assert_positive_1/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Y
Shape_3Shapecontrol_dependency*
out_type0*
_output_shapes
:*
T0
X
	unstack_1UnpackShape_3*

axis *
_output_shapes
: : : *	
num*
T0
P
GreaterEqual/yConst*
dtype0*
_output_shapes
: *
value	B : 
V
GreaterEqualGreaterEqualMaximumGreaterEqual/y*
T0*
_output_shapes
: 
g
Assert/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
o
Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
X
Assert/AssertAssertGreaterEqualAssert/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_1/yConst*
dtype0*
_output_shapes
: *
value	B : 
\
GreaterEqual_1GreaterEqual	Maximum_2GreaterEqual_1/y*
_output_shapes
: *
T0
j
Assert_1/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
r
Assert_1/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
^
Assert_1/AssertAssertGreaterEqual_1Assert_1/Assert/data_0*

T
2*
	summarize
K
	Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
I
GreaterGreater	Minimum_1	Greater/y*
_output_shapes
: *
T0
h
Assert_2/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
p
Assert_2/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
W
Assert_2/AssertAssertGreaterAssert_2/Assert/data_0*
	summarize*

T
2
M
Greater_1/yConst*
value	B : *
_output_shapes
: *
dtype0
K
	Greater_1GreaterMinimumGreater_1/y*
_output_shapes
: *
T0
i
Assert_3/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
q
Assert_3/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
Y
Assert_3/AssertAssert	Greater_1Assert_3/Assert/data_0*
	summarize*

T
2
?
addAdd	Minimum_1Maximum*
_output_shapes
: *
T0
Q
GreaterEqual_2GreaterEqualunstack_1:1add*
_output_shapes
: *
T0
p
Assert_4/ConstConst*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
x
Assert_4/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
^
Assert_4/AssertAssertGreaterEqual_2Assert_4/Assert/data_0*

T
2*
	summarize
A
add_1AddMinimum	Maximum_2*
_output_shapes
: *
T0
Q
GreaterEqual_3GreaterEqual	unstack_1add_1*
_output_shapes
: *
T0
q
Assert_5/ConstConst*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
y
Assert_5/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
^
Assert_5/AssertAssertGreaterEqual_3Assert_5/Assert/data_0*

T
2*
	summarize
Г
control_dependency_1Identitycontrol_dependency,^assert_positive_1/assert_less/Assert/Assert^Assert/Assert^Assert_1/Assert^Assert_2/Assert^Assert_3/Assert^Assert_4/Assert^Assert_5/Assert*
T0*
_class
loc:@DecodeJpeg*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
I
stack/2Const*
value	B : *
dtype0*
_output_shapes
: 
d
stackPack	Maximum_2Maximumstack/2*
N*
T0*
_output_shapes
:*

axis 
T
	stack_1/2Const*
dtype0*
_output_shapes
: *
valueB :
џџџџџџџџџ
h
stack_1PackMinimum	Minimum_1	stack_1/2*
N*
T0*
_output_shapes
:*

axis 

SliceSlicecontrol_dependency_1stackstack_1*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
L
Shape_4ShapeSlice*
T0*
_output_shapes
:*
out_type0
Y
assert_positive_2/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
q
"assert_positive_2/assert_less/LessLessassert_positive_2/ConstShape_4*
T0*
_output_shapes
:
m
#assert_positive_2/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
І
!assert_positive_2/assert_less/AllAll"assert_positive_2/assert_less/Less#assert_positive_2/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_2/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

2assert_positive_2/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_2/assert_less/Assert/AssertAssert!assert_positive_2/assert_less/All2assert_positive_2/assert_less/Assert/Assert/data_0*

T
2*
	summarize
L
Shape_5ShapeSlice*
_output_shapes
:*
out_type0*
T0
X
	unstack_2UnpackShape_5*	
num*
T0*

axis *
_output_shapes
: : : 
J
sub_2/xConst*
value
B :*
dtype0*
_output_shapes
: 
A
sub_2Subsub_2/x	Maximum_1*
_output_shapes
: *
T0
A
sub_3Subsub_2unstack_2:1*
_output_shapes
: *
T0
I
sub_4/xConst*
value	B :P*
_output_shapes
: *
dtype0
A
sub_4Subsub_4/x	Maximum_3*
T0*
_output_shapes
: 
?
sub_5Subsub_4	unstack_2*
_output_shapes
: *
T0
R
GreaterEqual_4/yConst*
_output_shapes
: *
dtype0*
value	B : 
\
GreaterEqual_4GreaterEqual	Maximum_3GreaterEqual_4/y*
T0*
_output_shapes
: 
i
Assert_6/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
q
Assert_6/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
^
Assert_6/AssertAssertGreaterEqual_4Assert_6/Assert/data_0*
	summarize*

T
2
R
GreaterEqual_5/yConst*
dtype0*
_output_shapes
: *
value	B : 
\
GreaterEqual_5GreaterEqual	Maximum_1GreaterEqual_5/y*
_output_shapes
: *
T0
h
Assert_7/ConstConst**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
p
Assert_7/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
^
Assert_7/AssertAssertGreaterEqual_5Assert_7/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_6/yConst*
value	B : *
_output_shapes
: *
dtype0
X
GreaterEqual_6GreaterEqualsub_3GreaterEqual_6/y*
T0*
_output_shapes
: 
o
Assert_8/ConstConst*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
w
Assert_8/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
^
Assert_8/AssertAssertGreaterEqual_6Assert_8/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_7/yConst*
dtype0*
_output_shapes
: *
value	B : 
X
GreaterEqual_7GreaterEqualsub_5GreaterEqual_7/y*
T0*
_output_shapes
: 
p
Assert_9/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_9/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
^
Assert_9/AssertAssertGreaterEqual_7Assert_9/Assert/data_0*
	summarize*

T
2
џ
control_dependency_2IdentitySlice,^assert_positive_2/assert_less/Assert/Assert^Assert_6/Assert^Assert_7/Assert^Assert_8/Assert^Assert_9/Assert*
_class

loc:@Slice*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
K
	stack_2/4Const*
value	B : *
dtype0*
_output_shapes
: 
K
	stack_2/5Const*
dtype0*
_output_shapes
: *
value	B : 

stack_2Pack	Maximum_3sub_5	Maximum_1sub_3	stack_2/4	stack_2/5*
T0*

axis *
N*
_output_shapes
:
^
Reshape/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
a
ReshapeReshapestack_2Reshape/shape*
T0*
Tshape0*
_output_shapes

:
q
PadPadcontrol_dependency_2Reshape*,
_output_shapes
:Pџџџџџџџџџ*
T0*
	Tpaddings0
J
Shape_6ShapePad*
T0*
out_type0*
_output_shapes
:
X
	unstack_3UnpackShape_6*

axis *
_output_shapes
: : : *	
num*
T0
t
control_dependency_3IdentityPad*
_class

loc:@Pad*,
_output_shapes
:Pџџџџџџџџџ*
T0
d
Reshape_1/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
w
	Reshape_1Reshapecontrol_dependency_3Reshape_1/shape*
T0*#
_output_shapes
:P*
Tshape0
W
ToFloatCast	Reshape_1*#
_output_shapes
:P*

DstT0*

SrcT0
J
div/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
L
divRealDivToFloatdiv/y*
T0*#
_output_shapes
:P
L
sub_6/yConst*
valueB
 *   ?*
dtype0*
_output_shapes
: 
H
sub_6Subdivsub_6/y*#
_output_shapes
:P*
T0
t
shuffle_batch/ConstConst*
_output_shapes
:*
dtype0*-
value$B""      №?                
W
shuffle_batch/Const_1Const*
value	B
 Z*
_output_shapes
: *
dtype0

і
"shuffle_batch/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*

seed *
shared_name *
min_after_dequeue
*
capacity*
	container *
seed2 *
_output_shapes
: *
component_types
2
t
shuffle_batch/cond/SwitchSwitchshuffle_batch/Const_1shuffle_batch/Const_1*
T0
*
_output_shapes
: : 
e
shuffle_batch/cond/switch_tIdentityshuffle_batch/cond/Switch:1*
_output_shapes
: *
T0

c
shuffle_batch/cond/switch_fIdentityshuffle_batch/cond/Switch*
_output_shapes
: *
T0

^
shuffle_batch/cond/pred_idIdentityshuffle_batch/Const_1*
T0
*
_output_shapes
: 
к
6shuffle_batch/cond/random_shuffle_queue_enqueue/SwitchSwitch"shuffle_batch/random_shuffle_queueshuffle_batch/cond/pred_id*
T0*5
_class+
)'loc:@shuffle_batch/random_shuffle_queue*
_output_shapes
: : 
М
8shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_6shuffle_batch/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class

loc:@sub_6
Ц
8shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch/Constshuffle_batch/cond/pred_id* 
_output_shapes
::*&
_class
loc:@shuffle_batch/Const*
T0
Ѕ
/shuffle_batch/cond/random_shuffle_queue_enqueueQueueEnqueueV28shuffle_batch/cond/random_shuffle_queue_enqueue/Switch:1:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1:1:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
б
%shuffle_batch/cond/control_dependencyIdentityshuffle_batch/cond/switch_t0^shuffle_batch/cond/random_shuffle_queue_enqueue*
T0
*.
_class$
" loc:@shuffle_batch/cond/switch_t*
_output_shapes
: 
=
shuffle_batch/cond/NoOpNoOp^shuffle_batch/cond/switch_f
Л
'shuffle_batch/cond/control_dependency_1Identityshuffle_batch/cond/switch_f^shuffle_batch/cond/NoOp*
T0
*
_output_shapes
: *.
_class$
" loc:@shuffle_batch/cond/switch_f

shuffle_batch/cond/MergeMerge'shuffle_batch/cond/control_dependency_1%shuffle_batch/cond/control_dependency*
T0
*
N*
_output_shapes
: : 
{
(shuffle_batch/random_shuffle_queue_CloseQueueCloseV2"shuffle_batch/random_shuffle_queue*
cancel_pending_enqueues( 
}
*shuffle_batch/random_shuffle_queue_Close_1QueueCloseV2"shuffle_batch/random_shuffle_queue*
cancel_pending_enqueues(
r
'shuffle_batch/random_shuffle_queue_SizeQueueSizeV2"shuffle_batch/random_shuffle_queue*
_output_shapes
: 
U
shuffle_batch/sub/yConst*
dtype0*
_output_shapes
: *
value	B :

w
shuffle_batch/subSub'shuffle_batch/random_shuffle_queue_Sizeshuffle_batch/sub/y*
T0*
_output_shapes
: 
Y
shuffle_batch/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
m
shuffle_batch/MaximumMaximumshuffle_batch/Maximum/xshuffle_batch/sub*
_output_shapes
: *
T0
a
shuffle_batch/CastCastshuffle_batch/Maximum*

SrcT0*
_output_shapes
: *

DstT0
X
shuffle_batch/mul/yConst*
valueB
 *ЋЊЊ=*
dtype0*
_output_shapes
: 
b
shuffle_batch/mulMulshuffle_batch/Castshuffle_batch/mul/y*
_output_shapes
: *
T0

.shuffle_batch/fraction_over_10_of_12_full/tagsConst*
_output_shapes
: *
dtype0*:
value1B/ B)shuffle_batch/fraction_over_10_of_12_full

)shuffle_batch/fraction_over_10_of_12_fullScalarSummary.shuffle_batch/fraction_over_10_of_12_full/tagsshuffle_batch/mul*
_output_shapes
: *
T0
Q
shuffle_batch/nConst*
_output_shapes
: *
dtype0*
value	B :
С
shuffle_batchQueueDequeueManyV2"shuffle_batch/random_shuffle_queueshuffle_batch/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
x
*matching_filenames_1/MatchingFiles/patternConst*
dtype0*
_output_shapes
: *
valueB BTrain/1/*.jpg

"matching_filenames_1/MatchingFilesMatchingFiles*matching_filenames_1/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_1
VariableV2*
shape:*
shared_name *
dtype0*
_output_shapes
:*
	container 
п
matching_filenames_1/AssignAssignmatching_filenames_1"matching_filenames_1/MatchingFiles*
use_locking(*
T0*'
_class
loc:@matching_filenames_1*
validate_shape( *#
_output_shapes
:џџџџџџџџџ

matching_filenames_1/readIdentitymatching_filenames_1*
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_1
i
input_producer_1/SizeSizematching_filenames_1/read*
out_type0*
_output_shapes
: *
T0
\
input_producer_1/Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
w
input_producer_1/GreaterGreaterinput_producer_1/Sizeinput_producer_1/Greater/y*
T0*
_output_shapes
: 

input_producer_1/Assert/ConstConst*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_1/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_1/Assert/AssertAssertinput_producer_1/Greater%input_producer_1/Assert/Assert/data_0*
	summarize*

T
2

input_producer_1/IdentityIdentitymatching_filenames_1/read^input_producer_1/Assert/Assert*
T0*
_output_shapes
:

input_producer_1FIFOQueueV2*
shapes
: *
	container *
_output_shapes
: *
component_types
2*
capacity *
shared_name 
Ё
-input_producer_1/input_producer_1_EnqueueManyQueueEnqueueManyV2input_producer_1input_producer_1/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_1/input_producer_1_CloseQueueCloseV2input_producer_1*
cancel_pending_enqueues( 
j
)input_producer_1/input_producer_1_Close_1QueueCloseV2input_producer_1*
cancel_pending_enqueues(
_
&input_producer_1/input_producer_1_SizeQueueSizeV2input_producer_1*
_output_shapes
: 
u
input_producer_1/CastCast&input_producer_1/input_producer_1_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_1/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_1/mulMulinput_producer_1/Castinput_producer_1/mul/y*
_output_shapes
: *
T0

)input_producer_1/fraction_of_32_full/tagsConst*
dtype0*
_output_shapes
: *5
value,B* B$input_producer_1/fraction_of_32_full

$input_producer_1/fraction_of_32_fullScalarSummary)input_producer_1/fraction_of_32_full/tagsinput_producer_1/mul*
T0*
_output_shapes
: 
d
WholeFileReaderV2_1WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_1ReaderReadV2WholeFileReaderV2_1input_producer_1*
_output_shapes
: : 
ь
DecodeJpeg_1
DecodeJpegReaderReadV2_1:1*

dct_method *
channels *
acceptable_fraction%  ?*
fancy_upscaling(*
try_recover_truncated( *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio
S
Shape_7ShapeDecodeJpeg_1*
out_type0*
_output_shapes
:*
T0
Y
assert_positive_3/ConstConst*
value	B : *
_output_shapes
: *
dtype0
q
"assert_positive_3/assert_less/LessLessassert_positive_3/ConstShape_7*
_output_shapes
:*
T0
m
#assert_positive_3/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
І
!assert_positive_3/assert_less/AllAll"assert_positive_3/assert_less/Less#assert_positive_3/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_3/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_3/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_3/assert_less/Assert/AssertAssert!assert_positive_3/assert_less/All2assert_positive_3/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Х
control_dependency_4IdentityDecodeJpeg_1,^assert_positive_3/assert_less/Assert/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_1*
T0
[
Shape_8Shapecontrol_dependency_4*
out_type0*
_output_shapes
:*
T0
X
	unstack_4UnpackShape_8*	
num*
T0*

axis *
_output_shapes
: : : 
J
sub_7/xConst*
value
B :*
dtype0*
_output_shapes
: 
C
sub_7Subsub_7/xunstack_4:1*
_output_shapes
: *
T0
4
Neg_2Negsub_7*
T0*
_output_shapes
: 
N
floordiv_4/yConst*
dtype0*
_output_shapes
: *
value	B :
L

floordiv_4FloorDivNeg_2floordiv_4/y*
_output_shapes
: *
T0
M
Maximum_4/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_4Maximum
floordiv_4Maximum_4/y*
T0*
_output_shapes
: 
N
floordiv_5/yConst*
dtype0*
_output_shapes
: *
value	B :
L

floordiv_5FloorDivsub_7floordiv_5/y*
T0*
_output_shapes
: 
M
Maximum_5/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_5Maximum
floordiv_5Maximum_5/y*
_output_shapes
: *
T0
I
sub_8/xConst*
_output_shapes
: *
dtype0*
value	B :P
A
sub_8Subsub_8/x	unstack_4*
T0*
_output_shapes
: 
4
Neg_3Negsub_8*
_output_shapes
: *
T0
N
floordiv_6/yConst*
value	B :*
_output_shapes
: *
dtype0
L

floordiv_6FloorDivNeg_3floordiv_6/y*
_output_shapes
: *
T0
M
Maximum_6/yConst*
_output_shapes
: *
dtype0*
value	B : 
N
	Maximum_6Maximum
floordiv_6Maximum_6/y*
_output_shapes
: *
T0
N
floordiv_7/yConst*
_output_shapes
: *
dtype0*
value	B :
L

floordiv_7FloorDivsub_8floordiv_7/y*
_output_shapes
: *
T0
M
Maximum_7/yConst*
_output_shapes
: *
dtype0*
value	B : 
N
	Maximum_7Maximum
floordiv_7Maximum_7/y*
_output_shapes
: *
T0
M
Minimum_2/xConst*
dtype0*
_output_shapes
: *
value	B :P
M
	Minimum_2MinimumMinimum_2/x	unstack_4*
T0*
_output_shapes
: 
N
Minimum_3/xConst*
dtype0*
_output_shapes
: *
value
B :
O
	Minimum_3MinimumMinimum_3/xunstack_4:1*
T0*
_output_shapes
: 
[
Shape_9Shapecontrol_dependency_4*
out_type0*
_output_shapes
:*
T0
Y
assert_positive_4/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
q
"assert_positive_4/assert_less/LessLessassert_positive_4/ConstShape_9*
_output_shapes
:*
T0
m
#assert_positive_4/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_4/assert_less/AllAll"assert_positive_4/assert_less/Less#assert_positive_4/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_4/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_4/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_4/assert_less/Assert/AssertAssert!assert_positive_4/assert_less/All2assert_positive_4/assert_less/Assert/Assert/data_0*

T
2*
	summarize
\
Shape_10Shapecontrol_dependency_4*
out_type0*
_output_shapes
:*
T0
Y
	unstack_5UnpackShape_10*	
num*
T0*

axis *
_output_shapes
: : : 
R
GreaterEqual_8/yConst*
value	B : *
_output_shapes
: *
dtype0
\
GreaterEqual_8GreaterEqual	Maximum_4GreaterEqual_8/y*
_output_shapes
: *
T0
j
Assert_10/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_10/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
`
Assert_10/AssertAssertGreaterEqual_8Assert_10/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_9/yConst*
value	B : *
_output_shapes
: *
dtype0
\
GreaterEqual_9GreaterEqual	Maximum_6GreaterEqual_9/y*
T0*
_output_shapes
: 
k
Assert_11/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_11/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
`
Assert_11/AssertAssertGreaterEqual_9Assert_11/Assert/data_0*
	summarize*

T
2
M
Greater_2/yConst*
_output_shapes
: *
dtype0*
value	B : 
M
	Greater_2Greater	Minimum_3Greater_2/y*
_output_shapes
: *
T0
i
Assert_12/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_12/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
[
Assert_12/AssertAssert	Greater_2Assert_12/Assert/data_0*
	summarize*

T
2
M
Greater_3/yConst*
value	B : *
dtype0*
_output_shapes
: 
M
	Greater_3Greater	Minimum_2Greater_3/y*
_output_shapes
: *
T0
j
Assert_13/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_13/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
[
Assert_13/AssertAssert	Greater_3Assert_13/Assert/data_0*

T
2*
	summarize
C
add_2Add	Minimum_3	Maximum_4*
T0*
_output_shapes
: 
T
GreaterEqual_10GreaterEqualunstack_5:1add_2*
_output_shapes
: *
T0
q
Assert_14/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_14/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_14/AssertAssertGreaterEqual_10Assert_14/Assert/data_0*
	summarize*

T
2
C
add_3Add	Minimum_2	Maximum_6*
_output_shapes
: *
T0
R
GreaterEqual_11GreaterEqual	unstack_5add_3*
T0*
_output_shapes
: 
r
Assert_15/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_15/Assert/data_0Const*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
a
Assert_15/AssertAssertGreaterEqual_11Assert_15/Assert/data_0*

T
2*
	summarize
П
control_dependency_5Identitycontrol_dependency_4,^assert_positive_4/assert_less/Assert/Assert^Assert_10/Assert^Assert_11/Assert^Assert_12/Assert^Assert_13/Assert^Assert_14/Assert^Assert_15/Assert*
T0*
_class
loc:@DecodeJpeg_1*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
K
	stack_3/2Const*
value	B : *
_output_shapes
: *
dtype0
j
stack_3Pack	Maximum_6	Maximum_4	stack_3/2*

axis *
_output_shapes
:*
T0*
N
T
	stack_4/2Const*
dtype0*
_output_shapes
: *
valueB :
џџџџџџџџџ
j
stack_4Pack	Minimum_2	Minimum_3	stack_4/2*
T0*

axis *
N*
_output_shapes
:

Slice_1Slicecontrol_dependency_5stack_3stack_4*
Index0*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
O
Shape_11ShapeSlice_1*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_5/ConstConst*
value	B : *
_output_shapes
: *
dtype0
r
"assert_positive_5/assert_less/LessLessassert_positive_5/ConstShape_11*
_output_shapes
:*
T0
m
#assert_positive_5/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
І
!assert_positive_5/assert_less/AllAll"assert_positive_5/assert_less/Less#assert_positive_5/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_5/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

2assert_positive_5/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_5/assert_less/Assert/AssertAssert!assert_positive_5/assert_less/All2assert_positive_5/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_12ShapeSlice_1*
_output_shapes
:*
out_type0*
T0
Y
	unstack_6UnpackShape_12*	
num*
T0*
_output_shapes
: : : *

axis 
J
sub_9/xConst*
value
B :*
dtype0*
_output_shapes
: 
A
sub_9Subsub_9/x	Maximum_5*
_output_shapes
: *
T0
B
sub_10Subsub_9unstack_6:1*
T0*
_output_shapes
: 
J
sub_11/xConst*
value	B :P*
_output_shapes
: *
dtype0
C
sub_11Subsub_11/x	Maximum_7*
_output_shapes
: *
T0
A
sub_12Subsub_11	unstack_6*
T0*
_output_shapes
: 
S
GreaterEqual_12/yConst*
value	B : *
_output_shapes
: *
dtype0
^
GreaterEqual_12GreaterEqual	Maximum_7GreaterEqual_12/y*
T0*
_output_shapes
: 
j
Assert_16/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
r
Assert_16/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
a
Assert_16/AssertAssertGreaterEqual_12Assert_16/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_13/yConst*
dtype0*
_output_shapes
: *
value	B : 
^
GreaterEqual_13GreaterEqual	Maximum_5GreaterEqual_13/y*
T0*
_output_shapes
: 
i
Assert_17/ConstConst**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
q
Assert_17/Assert/data_0Const**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
a
Assert_17/AssertAssertGreaterEqual_13Assert_17/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_14/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_14GreaterEqualsub_10GreaterEqual_14/y*
T0*
_output_shapes
: 
p
Assert_18/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
x
Assert_18/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_18/AssertAssertGreaterEqual_14Assert_18/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_15/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_15GreaterEqualsub_12GreaterEqual_15/y*
_output_shapes
: *
T0
q
Assert_19/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
y
Assert_19/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!height must be <= target - offset
a
Assert_19/AssertAssertGreaterEqual_15Assert_19/Assert/data_0*

T
2*
	summarize

control_dependency_6IdentitySlice_1,^assert_positive_5/assert_less/Assert/Assert^Assert_16/Assert^Assert_17/Assert^Assert_18/Assert^Assert_19/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_1*
T0
K
	stack_5/4Const*
_output_shapes
: *
dtype0*
value	B : 
K
	stack_5/5Const*
_output_shapes
: *
dtype0*
value	B : 

stack_5Pack	Maximum_7sub_12	Maximum_5sub_10	stack_5/4	stack_5/5*

axis *
_output_shapes
:*
T0*
N
`
Reshape_2/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
e
	Reshape_2Reshapestack_5Reshape_2/shape*
T0*
Tshape0*
_output_shapes

:
u
Pad_1Padcontrol_dependency_6	Reshape_2*
	Tpaddings0*
T0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_13ShapePad_1*
_output_shapes
:*
out_type0*
T0
Y
	unstack_7UnpackShape_13*	
num*
T0*
_output_shapes
: : : *

axis 
x
control_dependency_7IdentityPad_1*
T0*
_class

loc:@Pad_1*,
_output_shapes
:Pџџџџџџџџџ
d
Reshape_3/shapeConst*
_output_shapes
:*
dtype0*!
valueB"P         
w
	Reshape_3Reshapecontrol_dependency_7Reshape_3/shape*#
_output_shapes
:P*
Tshape0*
T0
Y
	ToFloat_1Cast	Reshape_3*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_1/yConst*
_output_shapes
: *
dtype0*
valueB
 *  C
R
div_1RealDiv	ToFloat_1div_1/y*
T0*#
_output_shapes
:P
M
sub_13/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
L
sub_13Subdiv_1sub_13/y*
T0*#
_output_shapes
:P
v
shuffle_batch_1/ConstConst*
dtype0*
_output_shapes
:*-
value$B""              №?        
Y
shuffle_batch_1/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_1/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
min_after_dequeue
*
capacity*
_output_shapes
: *
component_types
2*

seed *
shared_name *
	container *
seed2 
z
shuffle_batch_1/cond/SwitchSwitchshuffle_batch_1/Const_1shuffle_batch_1/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_1/cond/switch_tIdentityshuffle_batch_1/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_1/cond/switch_fIdentityshuffle_batch_1/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_1/cond/pred_idIdentityshuffle_batch_1/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_1/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_1/random_shuffle_queueshuffle_batch_1/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_1/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_13shuffle_batch_1/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_13
Ю
:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_1/Constshuffle_batch_1/cond/pred_id*(
_class
loc:@shuffle_batch_1/Const* 
_output_shapes
::*
T0
­
1shuffle_batch_1/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_1/cond/control_dependencyIdentityshuffle_batch_1/cond/switch_t2^shuffle_batch_1/cond/random_shuffle_queue_enqueue*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_1/cond/switch_t*
T0

A
shuffle_batch_1/cond/NoOpNoOp^shuffle_batch_1/cond/switch_f
У
)shuffle_batch_1/cond/control_dependency_1Identityshuffle_batch_1/cond/switch_f^shuffle_batch_1/cond/NoOp*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_1/cond/switch_f
Ѓ
shuffle_batch_1/cond/MergeMerge)shuffle_batch_1/cond/control_dependency_1'shuffle_batch_1/cond/control_dependency*
_output_shapes
: : *
T0
*
N

*shuffle_batch_1/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_1/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_1/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_1/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_1/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_1/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_1/sub/yConst*
_output_shapes
: *
dtype0*
value	B :

}
shuffle_batch_1/subSub)shuffle_batch_1/random_shuffle_queue_Sizeshuffle_batch_1/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_1/Maximum/xConst*
value	B : *
dtype0*
_output_shapes
: 
s
shuffle_batch_1/MaximumMaximumshuffle_batch_1/Maximum/xshuffle_batch_1/sub*
_output_shapes
: *
T0
e
shuffle_batch_1/CastCastshuffle_batch_1/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_1/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *ЋЊЊ=
h
shuffle_batch_1/mulMulshuffle_batch_1/Castshuffle_batch_1/mul/y*
_output_shapes
: *
T0

0shuffle_batch_1/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_1/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_1/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_1/fraction_over_10_of_12_full/tagsshuffle_batch_1/mul*
_output_shapes
: *
T0
S
shuffle_batch_1/nConst*
_output_shapes
: *
dtype0*
value	B :
Ч
shuffle_batch_1QueueDequeueManyV2$shuffle_batch_1/random_shuffle_queueshuffle_batch_1/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
x
*matching_filenames_2/MatchingFiles/patternConst*
_output_shapes
: *
dtype0*
valueB BTrain/2/*.jpg

"matching_filenames_2/MatchingFilesMatchingFiles*matching_filenames_2/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_2
VariableV2*
shared_name *
dtype0*
shape:*
_output_shapes
:*
	container 
п
matching_filenames_2/AssignAssignmatching_filenames_2"matching_filenames_2/MatchingFiles*
use_locking(*
T0*'
_class
loc:@matching_filenames_2*
validate_shape( *#
_output_shapes
:џџџџџџџџџ

matching_filenames_2/readIdentitymatching_filenames_2*
T0*'
_class
loc:@matching_filenames_2*
_output_shapes
:
i
input_producer_2/SizeSizematching_filenames_2/read*
T0*
out_type0*
_output_shapes
: 
\
input_producer_2/Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
w
input_producer_2/GreaterGreaterinput_producer_2/Sizeinput_producer_2/Greater/y*
_output_shapes
: *
T0

input_producer_2/Assert/ConstConst*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_2/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_2/Assert/AssertAssertinput_producer_2/Greater%input_producer_2/Assert/Assert/data_0*
	summarize*

T
2

input_producer_2/IdentityIdentitymatching_filenames_2/read^input_producer_2/Assert/Assert*
T0*
_output_shapes
:

input_producer_2FIFOQueueV2*
shapes
: *
_output_shapes
: *
component_types
2*
	container *
capacity *
shared_name 
Ё
-input_producer_2/input_producer_2_EnqueueManyQueueEnqueueManyV2input_producer_2input_producer_2/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_2/input_producer_2_CloseQueueCloseV2input_producer_2*
cancel_pending_enqueues( 
j
)input_producer_2/input_producer_2_Close_1QueueCloseV2input_producer_2*
cancel_pending_enqueues(
_
&input_producer_2/input_producer_2_SizeQueueSizeV2input_producer_2*
_output_shapes
: 
u
input_producer_2/CastCast&input_producer_2/input_producer_2_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_2/mul/yConst*
valueB
 *   =*
dtype0*
_output_shapes
: 
k
input_producer_2/mulMulinput_producer_2/Castinput_producer_2/mul/y*
_output_shapes
: *
T0

)input_producer_2/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_2/fraction_of_32_full

$input_producer_2/fraction_of_32_fullScalarSummary)input_producer_2/fraction_of_32_full/tagsinput_producer_2/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_2WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
_
ReaderReadV2_2ReaderReadV2WholeFileReaderV2_2input_producer_2*
_output_shapes
: : 
ь
DecodeJpeg_2
DecodeJpegReaderReadV2_2:1*

dct_method *
fancy_upscaling(*
try_recover_truncated( *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
acceptable_fraction%  ?*
channels 
T
Shape_14ShapeDecodeJpeg_2*
T0*
out_type0*
_output_shapes
:
Y
assert_positive_6/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
r
"assert_positive_6/assert_less/LessLessassert_positive_6/ConstShape_14*
_output_shapes
:*
T0
m
#assert_positive_6/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_6/assert_less/AllAll"assert_positive_6/assert_less/Less#assert_positive_6/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

*assert_positive_6/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_6/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_6/assert_less/Assert/AssertAssert!assert_positive_6/assert_less/All2assert_positive_6/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Х
control_dependency_8IdentityDecodeJpeg_2,^assert_positive_6/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg_2*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
\
Shape_15Shapecontrol_dependency_8*
T0*
_output_shapes
:*
out_type0
Y
	unstack_8UnpackShape_15*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_14/xConst*
_output_shapes
: *
dtype0*
value
B :
E
sub_14Subsub_14/xunstack_8:1*
T0*
_output_shapes
: 
5
Neg_4Negsub_14*
T0*
_output_shapes
: 
N
floordiv_8/yConst*
value	B :*
dtype0*
_output_shapes
: 
L

floordiv_8FloorDivNeg_4floordiv_8/y*
T0*
_output_shapes
: 
M
Maximum_8/yConst*
_output_shapes
: *
dtype0*
value	B : 
N
	Maximum_8Maximum
floordiv_8Maximum_8/y*
T0*
_output_shapes
: 
N
floordiv_9/yConst*
value	B :*
dtype0*
_output_shapes
: 
M

floordiv_9FloorDivsub_14floordiv_9/y*
T0*
_output_shapes
: 
M
Maximum_9/yConst*
value	B : *
dtype0*
_output_shapes
: 
N
	Maximum_9Maximum
floordiv_9Maximum_9/y*
T0*
_output_shapes
: 
J
sub_15/xConst*
dtype0*
_output_shapes
: *
value	B :P
C
sub_15Subsub_15/x	unstack_8*
T0*
_output_shapes
: 
5
Neg_5Negsub_15*
_output_shapes
: *
T0
O
floordiv_10/yConst*
value	B :*
_output_shapes
: *
dtype0
N
floordiv_10FloorDivNeg_5floordiv_10/y*
T0*
_output_shapes
: 
N
Maximum_10/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_10Maximumfloordiv_10Maximum_10/y*
T0*
_output_shapes
: 
O
floordiv_11/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_11FloorDivsub_15floordiv_11/y*
T0*
_output_shapes
: 
N
Maximum_11/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_11Maximumfloordiv_11Maximum_11/y*
T0*
_output_shapes
: 
M
Minimum_4/xConst*
value	B :P*
dtype0*
_output_shapes
: 
M
	Minimum_4MinimumMinimum_4/x	unstack_8*
_output_shapes
: *
T0
N
Minimum_5/xConst*
value
B :*
dtype0*
_output_shapes
: 
O
	Minimum_5MinimumMinimum_5/xunstack_8:1*
T0*
_output_shapes
: 
\
Shape_16Shapecontrol_dependency_8*
T0*
_output_shapes
:*
out_type0
Y
assert_positive_7/ConstConst*
value	B : *
_output_shapes
: *
dtype0
r
"assert_positive_7/assert_less/LessLessassert_positive_7/ConstShape_16*
T0*
_output_shapes
:
m
#assert_positive_7/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_7/assert_less/AllAll"assert_positive_7/assert_less/Less#assert_positive_7/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_7/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_7/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_7/assert_less/Assert/AssertAssert!assert_positive_7/assert_less/All2assert_positive_7/assert_less/Assert/Assert/data_0*
	summarize*

T
2
\
Shape_17Shapecontrol_dependency_8*
T0*
_output_shapes
:*
out_type0
Y
	unstack_9UnpackShape_17*	
num*
T0*
_output_shapes
: : : *

axis 
S
GreaterEqual_16/yConst*
dtype0*
_output_shapes
: *
value	B : 
^
GreaterEqual_16GreaterEqual	Maximum_8GreaterEqual_16/y*
T0*
_output_shapes
: 
j
Assert_20/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_20/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
a
Assert_20/AssertAssertGreaterEqual_16Assert_20/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_17/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_17GreaterEqual
Maximum_10GreaterEqual_17/y*
_output_shapes
: *
T0
k
Assert_21/ConstConst*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
s
Assert_21/Assert/data_0Const*
dtype0*
_output_shapes
: *,
value#B! Boffset_height must be >= 0.
a
Assert_21/AssertAssertGreaterEqual_17Assert_21/Assert/data_0*

T
2*
	summarize
M
Greater_4/yConst*
value	B : *
_output_shapes
: *
dtype0
M
	Greater_4Greater	Minimum_5Greater_4/y*
T0*
_output_shapes
: 
i
Assert_22/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_22/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
[
Assert_22/AssertAssert	Greater_4Assert_22/Assert/data_0*
	summarize*

T
2
M
Greater_5/yConst*
value	B : *
_output_shapes
: *
dtype0
M
	Greater_5Greater	Minimum_4Greater_5/y*
T0*
_output_shapes
: 
j
Assert_23/ConstConst*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
r
Assert_23/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
[
Assert_23/AssertAssert	Greater_5Assert_23/Assert/data_0*

T
2*
	summarize
C
add_4Add	Minimum_5	Maximum_8*
T0*
_output_shapes
: 
T
GreaterEqual_18GreaterEqualunstack_9:1add_4*
_output_shapes
: *
T0
q
Assert_24/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_24/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_24/AssertAssertGreaterEqual_18Assert_24/Assert/data_0*

T
2*
	summarize
D
add_5Add	Minimum_4
Maximum_10*
T0*
_output_shapes
: 
R
GreaterEqual_19GreaterEqual	unstack_9add_5*
_output_shapes
: *
T0
r
Assert_25/ConstConst*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
z
Assert_25/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_25/AssertAssertGreaterEqual_19Assert_25/Assert/data_0*
	summarize*

T
2
П
control_dependency_9Identitycontrol_dependency_8,^assert_positive_7/assert_less/Assert/Assert^Assert_20/Assert^Assert_21/Assert^Assert_22/Assert^Assert_23/Assert^Assert_24/Assert^Assert_25/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_2
K
	stack_6/2Const*
value	B : *
dtype0*
_output_shapes
: 
k
stack_6Pack
Maximum_10	Maximum_8	stack_6/2*
_output_shapes
:*
N*

axis *
T0
T
	stack_7/2Const*
dtype0*
_output_shapes
: *
valueB :
џџџџџџџџџ
j
stack_7Pack	Minimum_4	Minimum_5	stack_7/2*
T0*

axis *
N*
_output_shapes
:

Slice_2Slicecontrol_dependency_9stack_6stack_7*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_18ShapeSlice_2*
T0*
_output_shapes
:*
out_type0
Y
assert_positive_8/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
r
"assert_positive_8/assert_less/LessLessassert_positive_8/ConstShape_18*
_output_shapes
:*
T0
m
#assert_positive_8/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
І
!assert_positive_8/assert_less/AllAll"assert_positive_8/assert_less/Less#assert_positive_8/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

*assert_positive_8/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_8/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Љ
+assert_positive_8/assert_less/Assert/AssertAssert!assert_positive_8/assert_less/All2assert_positive_8/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_19ShapeSlice_2*
out_type0*
_output_shapes
:*
T0
Z

unstack_10UnpackShape_19*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_16/xConst*
value
B :*
dtype0*
_output_shapes
: 
C
sub_16Subsub_16/x	Maximum_9*
T0*
_output_shapes
: 
D
sub_17Subsub_16unstack_10:1*
T0*
_output_shapes
: 
J
sub_18/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_18Subsub_18/x
Maximum_11*
T0*
_output_shapes
: 
B
sub_19Subsub_18
unstack_10*
T0*
_output_shapes
: 
S
GreaterEqual_20/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_20GreaterEqual
Maximum_11GreaterEqual_20/y*
T0*
_output_shapes
: 
j
Assert_26/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
r
Assert_26/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
a
Assert_26/AssertAssertGreaterEqual_20Assert_26/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_21/yConst*
dtype0*
_output_shapes
: *
value	B : 
^
GreaterEqual_21GreaterEqual	Maximum_9GreaterEqual_21/y*
_output_shapes
: *
T0
i
Assert_27/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_27/Assert/data_0Const**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
a
Assert_27/AssertAssertGreaterEqual_21Assert_27/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_22/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_22GreaterEqualsub_17GreaterEqual_22/y*
T0*
_output_shapes
: 
p
Assert_28/ConstConst*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
x
Assert_28/Assert/data_0Const*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
a
Assert_28/AssertAssertGreaterEqual_22Assert_28/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_23/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_23GreaterEqualsub_19GreaterEqual_23/y*
T0*
_output_shapes
: 
q
Assert_29/ConstConst*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
y
Assert_29/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_29/AssertAssertGreaterEqual_23Assert_29/Assert/data_0*
	summarize*

T
2

control_dependency_10IdentitySlice_2,^assert_positive_8/assert_less/Assert/Assert^Assert_26/Assert^Assert_27/Assert^Assert_28/Assert^Assert_29/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_2
K
	stack_8/4Const*
value	B : *
dtype0*
_output_shapes
: 
K
	stack_8/5Const*
_output_shapes
: *
dtype0*
value	B : 

stack_8Pack
Maximum_11sub_19	Maximum_9sub_17	stack_8/4	stack_8/5*
_output_shapes
:*
N*

axis *
T0
`
Reshape_4/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
e
	Reshape_4Reshapestack_8Reshape_4/shape*
Tshape0*
_output_shapes

:*
T0
v
Pad_2Padcontrol_dependency_10	Reshape_4*
	Tpaddings0*
T0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_20ShapePad_2*
out_type0*
_output_shapes
:*
T0
Z

unstack_11UnpackShape_20*

axis *
_output_shapes
: : : *	
num*
T0
y
control_dependency_11IdentityPad_2*
T0*
_class

loc:@Pad_2*,
_output_shapes
:Pџџџџџџџџџ
d
Reshape_5/shapeConst*
_output_shapes
:*
dtype0*!
valueB"P         
x
	Reshape_5Reshapecontrol_dependency_11Reshape_5/shape*
T0*
Tshape0*#
_output_shapes
:P
Y
	ToFloat_2Cast	Reshape_5*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_2/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
R
div_2RealDiv	ToFloat_2div_2/y*
T0*#
_output_shapes
:P
M
sub_20/yConst*
valueB
 *   ?*
dtype0*
_output_shapes
: 
L
sub_20Subdiv_2sub_20/y*#
_output_shapes
:P*
T0
v
shuffle_batch_2/ConstConst*
dtype0*
_output_shapes
:*-
value$B""                      №?
Y
shuffle_batch_2/Const_1Const*
value	B
 Z*
dtype0
*
_output_shapes
: 
ј
$shuffle_batch_2/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
	container *
seed2 *
min_after_dequeue
*
capacity*
shared_name *

seed 
z
shuffle_batch_2/cond/SwitchSwitchshuffle_batch_2/Const_1shuffle_batch_2/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_2/cond/switch_tIdentityshuffle_batch_2/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_2/cond/switch_fIdentityshuffle_batch_2/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_2/cond/pred_idIdentityshuffle_batch_2/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_2/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_2/random_shuffle_queueshuffle_batch_2/cond/pred_id*
_output_shapes
: : *7
_class-
+)loc:@shuffle_batch_2/random_shuffle_queue*
T0
Т
:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_20shuffle_batch_2/cond/pred_id*2
_output_shapes 
:P:P*
_class
loc:@sub_20*
T0
Ю
:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_2/Constshuffle_batch_2/cond/pred_id*
T0*(
_class
loc:@shuffle_batch_2/Const* 
_output_shapes
::
­
1shuffle_batch_2/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_2/cond/control_dependencyIdentityshuffle_batch_2/cond/switch_t2^shuffle_batch_2/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_2/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_2/cond/NoOpNoOp^shuffle_batch_2/cond/switch_f
У
)shuffle_batch_2/cond/control_dependency_1Identityshuffle_batch_2/cond/switch_f^shuffle_batch_2/cond/NoOp*
T0
*0
_class&
$"loc:@shuffle_batch_2/cond/switch_f*
_output_shapes
: 
Ѓ
shuffle_batch_2/cond/MergeMerge)shuffle_batch_2/cond/control_dependency_1'shuffle_batch_2/cond/control_dependency*
T0
*
N*
_output_shapes
: : 

*shuffle_batch_2/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_2/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_2/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_2/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_2/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_2/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_2/sub/yConst*
value	B :
*
dtype0*
_output_shapes
: 
}
shuffle_batch_2/subSub)shuffle_batch_2/random_shuffle_queue_Sizeshuffle_batch_2/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_2/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
s
shuffle_batch_2/MaximumMaximumshuffle_batch_2/Maximum/xshuffle_batch_2/sub*
T0*
_output_shapes
: 
e
shuffle_batch_2/CastCastshuffle_batch_2/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_2/mul/yConst*
valueB
 *ЋЊЊ=*
dtype0*
_output_shapes
: 
h
shuffle_batch_2/mulMulshuffle_batch_2/Castshuffle_batch_2/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_2/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_2/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_2/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_2/fraction_over_10_of_12_full/tagsshuffle_batch_2/mul*
_output_shapes
: *
T0
S
shuffle_batch_2/nConst*
value	B :*
dtype0*
_output_shapes
: 
Ч
shuffle_batch_2QueueDequeueManyV2$shuffle_batch_2/random_shuffle_queueshuffle_batch_2/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
M
concat/axisConst*
_output_shapes
: *
dtype0*
value	B : 

concatConcatV2shuffle_batchshuffle_batch_1shuffle_batch_2concat/axis*'
_output_shapes
:P*
T0*

Tidx0*
N
O
concat_1/axisConst*
value	B : *
_output_shapes
: *
dtype0

concat_1ConcatV2shuffle_batch:1shuffle_batch_1:1shuffle_batch_2:1concat_1/axis*
_output_shapes

:*
N*
T0*

Tidx0
x
*matching_filenames_3/MatchingFiles/patternConst*
valueB BValid/0/*.jpg*
_output_shapes
: *
dtype0

"matching_filenames_3/MatchingFilesMatchingFiles*matching_filenames_3/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_3
VariableV2*
_output_shapes
:*
	container *
dtype0*
shared_name *
shape:
п
matching_filenames_3/AssignAssignmatching_filenames_3"matching_filenames_3/MatchingFiles*#
_output_shapes
:џџџџџџџџџ*
validate_shape( *'
_class
loc:@matching_filenames_3*
T0*
use_locking(

matching_filenames_3/readIdentitymatching_filenames_3*
_output_shapes
:*'
_class
loc:@matching_filenames_3*
T0
i
input_producer_3/SizeSizematching_filenames_3/read*
out_type0*
_output_shapes
: *
T0
\
input_producer_3/Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
w
input_producer_3/GreaterGreaterinput_producer_3/Sizeinput_producer_3/Greater/y*
T0*
_output_shapes
: 

input_producer_3/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

%input_producer_3/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_3/Assert/AssertAssertinput_producer_3/Greater%input_producer_3/Assert/Assert/data_0*
	summarize*

T
2

input_producer_3/IdentityIdentitymatching_filenames_3/read^input_producer_3/Assert/Assert*
_output_shapes
:*
T0

input_producer_3FIFOQueueV2*
shapes
: *
capacity *
	container *
shared_name *
_output_shapes
: *
component_types
2
Ё
-input_producer_3/input_producer_3_EnqueueManyQueueEnqueueManyV2input_producer_3input_producer_3/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_3/input_producer_3_CloseQueueCloseV2input_producer_3*
cancel_pending_enqueues( 
j
)input_producer_3/input_producer_3_Close_1QueueCloseV2input_producer_3*
cancel_pending_enqueues(
_
&input_producer_3/input_producer_3_SizeQueueSizeV2input_producer_3*
_output_shapes
: 
u
input_producer_3/CastCast&input_producer_3/input_producer_3_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_3/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_3/mulMulinput_producer_3/Castinput_producer_3/mul/y*
T0*
_output_shapes
: 

)input_producer_3/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_3/fraction_of_32_full*
dtype0*
_output_shapes
: 

$input_producer_3/fraction_of_32_fullScalarSummary)input_producer_3/fraction_of_32_full/tagsinput_producer_3/mul*
T0*
_output_shapes
: 
d
WholeFileReaderV2_3WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
_
ReaderReadV2_3ReaderReadV2WholeFileReaderV2_3input_producer_3*
_output_shapes
: : 
ь
DecodeJpeg_3
DecodeJpegReaderReadV2_3:1*
acceptable_fraction%  ?*

dct_method *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
fancy_upscaling(*
channels *
try_recover_truncated( 
T
Shape_21ShapeDecodeJpeg_3*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_9/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
r
"assert_positive_9/assert_less/LessLessassert_positive_9/ConstShape_21*
_output_shapes
:*
T0
m
#assert_positive_9/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
І
!assert_positive_9/assert_less/AllAll"assert_positive_9/assert_less/Less#assert_positive_9/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_9/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_9/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_9/assert_less/Assert/AssertAssert!assert_positive_9/assert_less/All2assert_positive_9/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ц
control_dependency_12IdentityDecodeJpeg_3,^assert_positive_9/assert_less/Assert/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_3
]
Shape_22Shapecontrol_dependency_12*
T0*
_output_shapes
:*
out_type0
Z

unstack_12UnpackShape_22*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_21/xConst*
value
B :*
dtype0*
_output_shapes
: 
F
sub_21Subsub_21/xunstack_12:1*
T0*
_output_shapes
: 
5
Neg_6Negsub_21*
_output_shapes
: *
T0
O
floordiv_12/yConst*
dtype0*
_output_shapes
: *
value	B :
N
floordiv_12FloorDivNeg_6floordiv_12/y*
_output_shapes
: *
T0
N
Maximum_12/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_12Maximumfloordiv_12Maximum_12/y*
T0*
_output_shapes
: 
O
floordiv_13/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_13FloorDivsub_21floordiv_13/y*
T0*
_output_shapes
: 
N
Maximum_13/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_13Maximumfloordiv_13Maximum_13/y*
T0*
_output_shapes
: 
J
sub_22/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_22Subsub_22/x
unstack_12*
_output_shapes
: *
T0
5
Neg_7Negsub_22*
_output_shapes
: *
T0
O
floordiv_14/yConst*
_output_shapes
: *
dtype0*
value	B :
N
floordiv_14FloorDivNeg_7floordiv_14/y*
_output_shapes
: *
T0
N
Maximum_14/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_14Maximumfloordiv_14Maximum_14/y*
T0*
_output_shapes
: 
O
floordiv_15/yConst*
_output_shapes
: *
dtype0*
value	B :
O
floordiv_15FloorDivsub_22floordiv_15/y*
T0*
_output_shapes
: 
N
Maximum_15/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_15Maximumfloordiv_15Maximum_15/y*
T0*
_output_shapes
: 
M
Minimum_6/xConst*
_output_shapes
: *
dtype0*
value	B :P
N
	Minimum_6MinimumMinimum_6/x
unstack_12*
T0*
_output_shapes
: 
N
Minimum_7/xConst*
_output_shapes
: *
dtype0*
value
B :
P
	Minimum_7MinimumMinimum_7/xunstack_12:1*
_output_shapes
: *
T0
]
Shape_23Shapecontrol_dependency_12*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_10/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_10/assert_less/LessLessassert_positive_10/ConstShape_23*
_output_shapes
:*
T0
n
$assert_positive_10/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_10/assert_less/AllAll#assert_positive_10/assert_less/Less$assert_positive_10/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_10/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_10/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_10/assert_less/Assert/AssertAssert"assert_positive_10/assert_less/All3assert_positive_10/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_24Shapecontrol_dependency_12*
T0*
out_type0*
_output_shapes
:
Z

unstack_13UnpackShape_24*	
num*
T0*

axis *
_output_shapes
: : : 
S
GreaterEqual_24/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_24GreaterEqual
Maximum_12GreaterEqual_24/y*
_output_shapes
: *
T0
j
Assert_30/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_30/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_30/AssertAssertGreaterEqual_24Assert_30/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_25/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_25GreaterEqual
Maximum_14GreaterEqual_25/y*
T0*
_output_shapes
: 
k
Assert_31/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_31/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_31/AssertAssertGreaterEqual_25Assert_31/Assert/data_0*
	summarize*

T
2
M
Greater_6/yConst*
dtype0*
_output_shapes
: *
value	B : 
M
	Greater_6Greater	Minimum_7Greater_6/y*
T0*
_output_shapes
: 
i
Assert_32/ConstConst*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
q
Assert_32/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
[
Assert_32/AssertAssert	Greater_6Assert_32/Assert/data_0*
	summarize*

T
2
M
Greater_7/yConst*
_output_shapes
: *
dtype0*
value	B : 
M
	Greater_7Greater	Minimum_6Greater_7/y*
_output_shapes
: *
T0
j
Assert_33/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_33/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
[
Assert_33/AssertAssert	Greater_7Assert_33/Assert/data_0*

T
2*
	summarize
D
add_6Add	Minimum_7
Maximum_12*
_output_shapes
: *
T0
U
GreaterEqual_26GreaterEqualunstack_13:1add_6*
_output_shapes
: *
T0
q
Assert_34/ConstConst*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
y
Assert_34/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
a
Assert_34/AssertAssertGreaterEqual_26Assert_34/Assert/data_0*

T
2*
	summarize
D
add_7Add	Minimum_6
Maximum_14*
_output_shapes
: *
T0
S
GreaterEqual_27GreaterEqual
unstack_13add_7*
T0*
_output_shapes
: 
r
Assert_35/ConstConst*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
z
Assert_35/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_35/AssertAssertGreaterEqual_27Assert_35/Assert/data_0*
	summarize*

T
2
Т
control_dependency_13Identitycontrol_dependency_12-^assert_positive_10/assert_less/Assert/Assert^Assert_30/Assert^Assert_31/Assert^Assert_32/Assert^Assert_33/Assert^Assert_34/Assert^Assert_35/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_3*
T0
K
	stack_9/2Const*
value	B : *
_output_shapes
: *
dtype0
l
stack_9Pack
Maximum_14
Maximum_12	stack_9/2*

axis *
_output_shapes
:*
T0*
N
U

stack_10/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
l
stack_10Pack	Minimum_6	Minimum_7
stack_10/2*
_output_shapes
:*
N*

axis *
T0

Slice_3Slicecontrol_dependency_13stack_9stack_10*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_25ShapeSlice_3*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_11/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_11/assert_less/LessLessassert_positive_11/ConstShape_25*
T0*
_output_shapes
:
n
$assert_positive_11/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
Љ
"assert_positive_11/assert_less/AllAll#assert_positive_11/assert_less/Less$assert_positive_11/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_11/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_11/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_11/assert_less/Assert/AssertAssert"assert_positive_11/assert_less/All3assert_positive_11/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_26ShapeSlice_3*
T0*
out_type0*
_output_shapes
:
Z

unstack_14UnpackShape_26*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_23/xConst*
value
B :*
_output_shapes
: *
dtype0
D
sub_23Subsub_23/x
Maximum_13*
_output_shapes
: *
T0
D
sub_24Subsub_23unstack_14:1*
T0*
_output_shapes
: 
J
sub_25/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_25Subsub_25/x
Maximum_15*
_output_shapes
: *
T0
B
sub_26Subsub_25
unstack_14*
T0*
_output_shapes
: 
S
GreaterEqual_28/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_28GreaterEqual
Maximum_15GreaterEqual_28/y*
_output_shapes
: *
T0
j
Assert_36/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
r
Assert_36/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
a
Assert_36/AssertAssertGreaterEqual_28Assert_36/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_29/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_29GreaterEqual
Maximum_13GreaterEqual_29/y*
_output_shapes
: *
T0
i
Assert_37/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_37/Assert/data_0Const**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
a
Assert_37/AssertAssertGreaterEqual_29Assert_37/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_30/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_30GreaterEqualsub_24GreaterEqual_30/y*
T0*
_output_shapes
: 
p
Assert_38/ConstConst*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
x
Assert_38/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_38/AssertAssertGreaterEqual_30Assert_38/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_31/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_31GreaterEqualsub_26GreaterEqual_31/y*
T0*
_output_shapes
: 
q
Assert_39/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
y
Assert_39/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_39/AssertAssertGreaterEqual_31Assert_39/Assert/data_0*
	summarize*

T
2

control_dependency_14IdentitySlice_3-^assert_positive_11/assert_less/Assert/Assert^Assert_36/Assert^Assert_37/Assert^Assert_38/Assert^Assert_39/Assert*
_class
loc:@Slice_3*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_11/4Const*
dtype0*
_output_shapes
: *
value	B : 
L

stack_11/5Const*
value	B : *
_output_shapes
: *
dtype0

stack_11Pack
Maximum_15sub_26
Maximum_13sub_24
stack_11/4
stack_11/5*
_output_shapes
:*
N*

axis *
T0
`
Reshape_6/shapeConst*
dtype0*
_output_shapes
:*
valueB"      
f
	Reshape_6Reshapestack_11Reshape_6/shape*
_output_shapes

:*
Tshape0*
T0
v
Pad_3Padcontrol_dependency_14	Reshape_6*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_27ShapePad_3*
out_type0*
_output_shapes
:*
T0
Z

unstack_15UnpackShape_27*
_output_shapes
: : : *

axis *	
num*
T0
y
control_dependency_15IdentityPad_3*
T0*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad_3
d
Reshape_7/shapeConst*!
valueB"P         *
dtype0*
_output_shapes
:
x
	Reshape_7Reshapecontrol_dependency_15Reshape_7/shape*
Tshape0*#
_output_shapes
:P*
T0
Y
	ToFloat_3Cast	Reshape_7*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_3/yConst*
valueB
 *  C*
dtype0*
_output_shapes
: 
R
div_3RealDiv	ToFloat_3div_3/y*
T0*#
_output_shapes
:P
M
sub_27/yConst*
valueB
 *   ?*
dtype0*
_output_shapes
: 
L
sub_27Subdiv_3sub_27/y*
T0*#
_output_shapes
:P
v
shuffle_batch_3/ConstConst*-
value$B""      №?                *
_output_shapes
:*
dtype0
Y
shuffle_batch_3/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_3/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
shared_name *
seed2 *
	container *

seed *
capacity*
min_after_dequeue

z
shuffle_batch_3/cond/SwitchSwitchshuffle_batch_3/Const_1shuffle_batch_3/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_3/cond/switch_tIdentityshuffle_batch_3/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_3/cond/switch_fIdentityshuffle_batch_3/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_3/cond/pred_idIdentityshuffle_batch_3/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_3/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_3/random_shuffle_queueshuffle_batch_3/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_3/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_27shuffle_batch_3/cond/pred_id*
_class
loc:@sub_27*2
_output_shapes 
:P:P*
T0
Ю
:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_3/Constshuffle_batch_3/cond/pred_id* 
_output_shapes
::*(
_class
loc:@shuffle_batch_3/Const*
T0
­
1shuffle_batch_3/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_3/cond/control_dependencyIdentityshuffle_batch_3/cond/switch_t2^shuffle_batch_3/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_3/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_3/cond/NoOpNoOp^shuffle_batch_3/cond/switch_f
У
)shuffle_batch_3/cond/control_dependency_1Identityshuffle_batch_3/cond/switch_f^shuffle_batch_3/cond/NoOp*0
_class&
$"loc:@shuffle_batch_3/cond/switch_f*
_output_shapes
: *
T0

Ѓ
shuffle_batch_3/cond/MergeMerge)shuffle_batch_3/cond/control_dependency_1'shuffle_batch_3/cond/control_dependency*
_output_shapes
: : *
T0
*
N

*shuffle_batch_3/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_3/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_3/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_3/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_3/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_3/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_3/sub/yConst*
value	B :
*
dtype0*
_output_shapes
: 
}
shuffle_batch_3/subSub)shuffle_batch_3/random_shuffle_queue_Sizeshuffle_batch_3/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_3/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_3/MaximumMaximumshuffle_batch_3/Maximum/xshuffle_batch_3/sub*
_output_shapes
: *
T0
e
shuffle_batch_3/CastCastshuffle_batch_3/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_3/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *ЋЊЊ=
h
shuffle_batch_3/mulMulshuffle_batch_3/Castshuffle_batch_3/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_3/fraction_over_10_of_12_full/tagsConst*
dtype0*
_output_shapes
: *<
value3B1 B+shuffle_batch_3/fraction_over_10_of_12_full
Є
+shuffle_batch_3/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_3/fraction_over_10_of_12_full/tagsshuffle_batch_3/mul*
_output_shapes
: *
T0
S
shuffle_batch_3/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_3QueueDequeueManyV2$shuffle_batch_3/random_shuffle_queueshuffle_batch_3/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
x
*matching_filenames_4/MatchingFiles/patternConst*
_output_shapes
: *
dtype0*
valueB BValid/1/*.jpg

"matching_filenames_4/MatchingFilesMatchingFiles*matching_filenames_4/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_4
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_4/AssignAssignmatching_filenames_4"matching_filenames_4/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_4

matching_filenames_4/readIdentitymatching_filenames_4*'
_class
loc:@matching_filenames_4*
_output_shapes
:*
T0
i
input_producer_4/SizeSizematching_filenames_4/read*
_output_shapes
: *
out_type0*
T0
\
input_producer_4/Greater/yConst*
_output_shapes
: *
dtype0*
value	B : 
w
input_producer_4/GreaterGreaterinput_producer_4/Sizeinput_producer_4/Greater/y*
_output_shapes
: *
T0

input_producer_4/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

%input_producer_4/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_4/Assert/AssertAssertinput_producer_4/Greater%input_producer_4/Assert/Assert/data_0*
	summarize*

T
2

input_producer_4/IdentityIdentitymatching_filenames_4/read^input_producer_4/Assert/Assert*
_output_shapes
:*
T0

input_producer_4FIFOQueueV2*
shapes
: *
capacity *
_output_shapes
: *
component_types
2*
shared_name *
	container 
Ё
-input_producer_4/input_producer_4_EnqueueManyQueueEnqueueManyV2input_producer_4input_producer_4/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_4/input_producer_4_CloseQueueCloseV2input_producer_4*
cancel_pending_enqueues( 
j
)input_producer_4/input_producer_4_Close_1QueueCloseV2input_producer_4*
cancel_pending_enqueues(
_
&input_producer_4/input_producer_4_SizeQueueSizeV2input_producer_4*
_output_shapes
: 
u
input_producer_4/CastCast&input_producer_4/input_producer_4_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_4/mul/yConst*
valueB
 *   =*
dtype0*
_output_shapes
: 
k
input_producer_4/mulMulinput_producer_4/Castinput_producer_4/mul/y*
T0*
_output_shapes
: 

)input_producer_4/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_4/fraction_of_32_full*
dtype0*
_output_shapes
: 

$input_producer_4/fraction_of_32_fullScalarSummary)input_producer_4/fraction_of_32_full/tagsinput_producer_4/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_4WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_4ReaderReadV2WholeFileReaderV2_4input_producer_4*
_output_shapes
: : 
ь
DecodeJpeg_4
DecodeJpegReaderReadV2_4:1*

dct_method *
channels *
acceptable_fraction%  ?*
fancy_upscaling(*
try_recover_truncated( *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio
T
Shape_28ShapeDecodeJpeg_4*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_12/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_12/assert_less/LessLessassert_positive_12/ConstShape_28*
T0*
_output_shapes
:
n
$assert_positive_12/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_12/assert_less/AllAll#assert_positive_12/assert_less/Less$assert_positive_12/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_12/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_12/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_12/assert_less/Assert/AssertAssert"assert_positive_12/assert_less/All3assert_positive_12/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_16IdentityDecodeJpeg_4-^assert_positive_12/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
]
Shape_29Shapecontrol_dependency_16*
T0*
out_type0*
_output_shapes
:
Z

unstack_16UnpackShape_29*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_28/xConst*
_output_shapes
: *
dtype0*
value
B :
F
sub_28Subsub_28/xunstack_16:1*
_output_shapes
: *
T0
5
Neg_8Negsub_28*
_output_shapes
: *
T0
O
floordiv_16/yConst*
value	B :*
_output_shapes
: *
dtype0
N
floordiv_16FloorDivNeg_8floordiv_16/y*
T0*
_output_shapes
: 
N
Maximum_16/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_16Maximumfloordiv_16Maximum_16/y*
_output_shapes
: *
T0
O
floordiv_17/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_17FloorDivsub_28floordiv_17/y*
_output_shapes
: *
T0
N
Maximum_17/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_17Maximumfloordiv_17Maximum_17/y*
_output_shapes
: *
T0
J
sub_29/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_29Subsub_29/x
unstack_16*
_output_shapes
: *
T0
5
Neg_9Negsub_29*
T0*
_output_shapes
: 
O
floordiv_18/yConst*
_output_shapes
: *
dtype0*
value	B :
N
floordiv_18FloorDivNeg_9floordiv_18/y*
T0*
_output_shapes
: 
N
Maximum_18/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_18Maximumfloordiv_18Maximum_18/y*
T0*
_output_shapes
: 
O
floordiv_19/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_19FloorDivsub_29floordiv_19/y*
_output_shapes
: *
T0
N
Maximum_19/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_19Maximumfloordiv_19Maximum_19/y*
_output_shapes
: *
T0
M
Minimum_8/xConst*
dtype0*
_output_shapes
: *
value	B :P
N
	Minimum_8MinimumMinimum_8/x
unstack_16*
T0*
_output_shapes
: 
N
Minimum_9/xConst*
value
B :*
dtype0*
_output_shapes
: 
P
	Minimum_9MinimumMinimum_9/xunstack_16:1*
T0*
_output_shapes
: 
]
Shape_30Shapecontrol_dependency_16*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_13/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
t
#assert_positive_13/assert_less/LessLessassert_positive_13/ConstShape_30*
_output_shapes
:*
T0
n
$assert_positive_13/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_13/assert_less/AllAll#assert_positive_13/assert_less/Less$assert_positive_13/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_13/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_13/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_13/assert_less/Assert/AssertAssert"assert_positive_13/assert_less/All3assert_positive_13/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_31Shapecontrol_dependency_16*
out_type0*
_output_shapes
:*
T0
Z

unstack_17UnpackShape_31*
_output_shapes
: : : *

axis *	
num*
T0
S
GreaterEqual_32/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_32GreaterEqual
Maximum_16GreaterEqual_32/y*
_output_shapes
: *
T0
j
Assert_40/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_40/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_40/AssertAssertGreaterEqual_32Assert_40/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_33/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_33GreaterEqual
Maximum_18GreaterEqual_33/y*
_output_shapes
: *
T0
k
Assert_41/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_41/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_41/AssertAssertGreaterEqual_33Assert_41/Assert/data_0*
	summarize*

T
2
M
Greater_8/yConst*
dtype0*
_output_shapes
: *
value	B : 
M
	Greater_8Greater	Minimum_9Greater_8/y*
T0*
_output_shapes
: 
i
Assert_42/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_42/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
[
Assert_42/AssertAssert	Greater_8Assert_42/Assert/data_0*
	summarize*

T
2
M
Greater_9/yConst*
dtype0*
_output_shapes
: *
value	B : 
M
	Greater_9Greater	Minimum_8Greater_9/y*
T0*
_output_shapes
: 
j
Assert_43/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_43/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
[
Assert_43/AssertAssert	Greater_9Assert_43/Assert/data_0*
	summarize*

T
2
D
add_8Add	Minimum_9
Maximum_16*
T0*
_output_shapes
: 
U
GreaterEqual_34GreaterEqualunstack_17:1add_8*
_output_shapes
: *
T0
q
Assert_44/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_44/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
a
Assert_44/AssertAssertGreaterEqual_34Assert_44/Assert/data_0*

T
2*
	summarize
D
add_9Add	Minimum_8
Maximum_18*
T0*
_output_shapes
: 
S
GreaterEqual_35GreaterEqual
unstack_17add_9*
T0*
_output_shapes
: 
r
Assert_45/ConstConst*3
value*B( B"height must be >= target + offset.*
dtype0*
_output_shapes
: 
z
Assert_45/Assert/data_0Const*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
a
Assert_45/AssertAssertGreaterEqual_35Assert_45/Assert/data_0*
	summarize*

T
2
Т
control_dependency_17Identitycontrol_dependency_16-^assert_positive_13/assert_less/Assert/Assert^Assert_40/Assert^Assert_41/Assert^Assert_42/Assert^Assert_43/Assert^Assert_44/Assert^Assert_45/Assert*
T0*
_class
loc:@DecodeJpeg_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_12/2Const*
dtype0*
_output_shapes
: *
value	B : 
n
stack_12Pack
Maximum_18
Maximum_16
stack_12/2*
T0*

axis *
N*
_output_shapes
:
U

stack_13/2Const*
_output_shapes
: *
dtype0*
valueB :
џџџџџџџџџ
l
stack_13Pack	Minimum_8	Minimum_9
stack_13/2*
N*
T0*
_output_shapes
:*

axis 

Slice_4Slicecontrol_dependency_17stack_12stack_13*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_32ShapeSlice_4*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_14/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
t
#assert_positive_14/assert_less/LessLessassert_positive_14/ConstShape_32*
_output_shapes
:*
T0
n
$assert_positive_14/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_14/assert_less/AllAll#assert_positive_14/assert_less/Less$assert_positive_14/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_14/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_14/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_14/assert_less/Assert/AssertAssert"assert_positive_14/assert_less/All3assert_positive_14/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_33ShapeSlice_4*
T0*
_output_shapes
:*
out_type0
Z

unstack_18UnpackShape_33*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_30/xConst*
_output_shapes
: *
dtype0*
value
B :
D
sub_30Subsub_30/x
Maximum_17*
T0*
_output_shapes
: 
D
sub_31Subsub_30unstack_18:1*
_output_shapes
: *
T0
J
sub_32/xConst*
value	B :P*
_output_shapes
: *
dtype0
D
sub_32Subsub_32/x
Maximum_19*
_output_shapes
: *
T0
B
sub_33Subsub_32
unstack_18*
T0*
_output_shapes
: 
S
GreaterEqual_36/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_36GreaterEqual
Maximum_19GreaterEqual_36/y*
_output_shapes
: *
T0
j
Assert_46/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
r
Assert_46/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
a
Assert_46/AssertAssertGreaterEqual_36Assert_46/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_37/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_37GreaterEqual
Maximum_17GreaterEqual_37/y*
T0*
_output_shapes
: 
i
Assert_47/ConstConst**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
q
Assert_47/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
a
Assert_47/AssertAssertGreaterEqual_37Assert_47/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_38/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_38GreaterEqualsub_31GreaterEqual_38/y*
T0*
_output_shapes
: 
p
Assert_48/ConstConst*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
x
Assert_48/Assert/data_0Const*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
a
Assert_48/AssertAssertGreaterEqual_38Assert_48/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_39/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_39GreaterEqualsub_33GreaterEqual_39/y*
_output_shapes
: *
T0
q
Assert_49/ConstConst*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
y
Assert_49/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_49/AssertAssertGreaterEqual_39Assert_49/Assert/data_0*
	summarize*

T
2

control_dependency_18IdentitySlice_4-^assert_positive_14/assert_less/Assert/Assert^Assert_46/Assert^Assert_47/Assert^Assert_48/Assert^Assert_49/Assert*
_class
loc:@Slice_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_14/4Const*
value	B : *
_output_shapes
: *
dtype0
L

stack_14/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_14Pack
Maximum_19sub_33
Maximum_17sub_31
stack_14/4
stack_14/5*

axis *
_output_shapes
:*
T0*
N
`
Reshape_8/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
f
	Reshape_8Reshapestack_14Reshape_8/shape*
_output_shapes

:*
Tshape0*
T0
v
Pad_4Padcontrol_dependency_18	Reshape_8*,
_output_shapes
:Pџџџџџџџџџ*
T0*
	Tpaddings0
M
Shape_34ShapePad_4*
T0*
out_type0*
_output_shapes
:
Z

unstack_19UnpackShape_34*

axis *
_output_shapes
: : : *	
num*
T0
y
control_dependency_19IdentityPad_4*
T0*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad_4
d
Reshape_9/shapeConst*
_output_shapes
:*
dtype0*!
valueB"P         
x
	Reshape_9Reshapecontrol_dependency_19Reshape_9/shape*
T0*#
_output_shapes
:P*
Tshape0
Y
	ToFloat_4Cast	Reshape_9*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_4/yConst*
_output_shapes
: *
dtype0*
valueB
 *  C
R
div_4RealDiv	ToFloat_4div_4/y*#
_output_shapes
:P*
T0
M
sub_34/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
L
sub_34Subdiv_4sub_34/y*
T0*#
_output_shapes
:P
v
shuffle_batch_4/ConstConst*-
value$B""              №?        *
dtype0*
_output_shapes
:
Y
shuffle_batch_4/Const_1Const*
dtype0
*
_output_shapes
: *
value	B
 Z
ј
$shuffle_batch_4/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
min_after_dequeue
*
capacity*

seed *
	container *
seed2 *
shared_name *
_output_shapes
: *
component_types
2
z
shuffle_batch_4/cond/SwitchSwitchshuffle_batch_4/Const_1shuffle_batch_4/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_4/cond/switch_tIdentityshuffle_batch_4/cond/Switch:1*
_output_shapes
: *
T0

g
shuffle_batch_4/cond/switch_fIdentityshuffle_batch_4/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_4/cond/pred_idIdentityshuffle_batch_4/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_4/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_4/random_shuffle_queueshuffle_batch_4/cond/pred_id*7
_class-
+)loc:@shuffle_batch_4/random_shuffle_queue*
_output_shapes
: : *
T0
Т
:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_34shuffle_batch_4/cond/pred_id*
T0*
_class
loc:@sub_34*2
_output_shapes 
:P:P
Ю
:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_4/Constshuffle_batch_4/cond/pred_id*
T0* 
_output_shapes
::*(
_class
loc:@shuffle_batch_4/Const
­
1shuffle_batch_4/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_4/cond/control_dependencyIdentityshuffle_batch_4/cond/switch_t2^shuffle_batch_4/cond/random_shuffle_queue_enqueue*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_4/cond/switch_t
A
shuffle_batch_4/cond/NoOpNoOp^shuffle_batch_4/cond/switch_f
У
)shuffle_batch_4/cond/control_dependency_1Identityshuffle_batch_4/cond/switch_f^shuffle_batch_4/cond/NoOp*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_4/cond/switch_f
Ѓ
shuffle_batch_4/cond/MergeMerge)shuffle_batch_4/cond/control_dependency_1'shuffle_batch_4/cond/control_dependency*
_output_shapes
: : *
T0
*
N

*shuffle_batch_4/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_4/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_4/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_4/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_4/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_4/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_4/sub/yConst*
value	B :
*
_output_shapes
: *
dtype0
}
shuffle_batch_4/subSub)shuffle_batch_4/random_shuffle_queue_Sizeshuffle_batch_4/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_4/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_4/MaximumMaximumshuffle_batch_4/Maximum/xshuffle_batch_4/sub*
T0*
_output_shapes
: 
e
shuffle_batch_4/CastCastshuffle_batch_4/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_4/mul/yConst*
valueB
 *ЋЊЊ=*
dtype0*
_output_shapes
: 
h
shuffle_batch_4/mulMulshuffle_batch_4/Castshuffle_batch_4/mul/y*
_output_shapes
: *
T0

0shuffle_batch_4/fraction_over_10_of_12_full/tagsConst*
_output_shapes
: *
dtype0*<
value3B1 B+shuffle_batch_4/fraction_over_10_of_12_full
Є
+shuffle_batch_4/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_4/fraction_over_10_of_12_full/tagsshuffle_batch_4/mul*
T0*
_output_shapes
: 
S
shuffle_batch_4/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_4QueueDequeueManyV2$shuffle_batch_4/random_shuffle_queueshuffle_batch_4/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
x
*matching_filenames_5/MatchingFiles/patternConst*
valueB BValid/2/*.jpg*
dtype0*
_output_shapes
: 

"matching_filenames_5/MatchingFilesMatchingFiles*matching_filenames_5/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_5
VariableV2*
shared_name *
dtype0*
shape:*
_output_shapes
:*
	container 
п
matching_filenames_5/AssignAssignmatching_filenames_5"matching_filenames_5/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_5

matching_filenames_5/readIdentitymatching_filenames_5*
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_5
i
input_producer_5/SizeSizematching_filenames_5/read*
_output_shapes
: *
out_type0*
T0
\
input_producer_5/Greater/yConst*
_output_shapes
: *
dtype0*
value	B : 
w
input_producer_5/GreaterGreaterinput_producer_5/Sizeinput_producer_5/Greater/y*
T0*
_output_shapes
: 

input_producer_5/Assert/ConstConst*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_5/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

input_producer_5/Assert/AssertAssertinput_producer_5/Greater%input_producer_5/Assert/Assert/data_0*

T
2*
	summarize

input_producer_5/IdentityIdentitymatching_filenames_5/read^input_producer_5/Assert/Assert*
_output_shapes
:*
T0

input_producer_5FIFOQueueV2*
shapes
: *
shared_name *
capacity *
	container *
_output_shapes
: *
component_types
2
Ё
-input_producer_5/input_producer_5_EnqueueManyQueueEnqueueManyV2input_producer_5input_producer_5/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_5/input_producer_5_CloseQueueCloseV2input_producer_5*
cancel_pending_enqueues( 
j
)input_producer_5/input_producer_5_Close_1QueueCloseV2input_producer_5*
cancel_pending_enqueues(
_
&input_producer_5/input_producer_5_SizeQueueSizeV2input_producer_5*
_output_shapes
: 
u
input_producer_5/CastCast&input_producer_5/input_producer_5_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_5/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_5/mulMulinput_producer_5/Castinput_producer_5/mul/y*
T0*
_output_shapes
: 

)input_producer_5/fraction_of_32_full/tagsConst*
dtype0*
_output_shapes
: *5
value,B* B$input_producer_5/fraction_of_32_full

$input_producer_5/fraction_of_32_fullScalarSummary)input_producer_5/fraction_of_32_full/tagsinput_producer_5/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_5WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_5ReaderReadV2WholeFileReaderV2_5input_producer_5*
_output_shapes
: : 
ь
DecodeJpeg_5
DecodeJpegReaderReadV2_5:1*
try_recover_truncated( *
channels *
fancy_upscaling(*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*

dct_method *
acceptable_fraction%  ?
T
Shape_35ShapeDecodeJpeg_5*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_15/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_15/assert_less/LessLessassert_positive_15/ConstShape_35*
_output_shapes
:*
T0
n
$assert_positive_15/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_15/assert_less/AllAll#assert_positive_15/assert_less/Less$assert_positive_15/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_15/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_15/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_15/assert_less/Assert/AssertAssert"assert_positive_15/assert_less/All3assert_positive_15/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Ч
control_dependency_20IdentityDecodeJpeg_5-^assert_positive_15/assert_less/Assert/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_5*
T0
]
Shape_36Shapecontrol_dependency_20*
_output_shapes
:*
out_type0*
T0
Z

unstack_20UnpackShape_36*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_35/xConst*
dtype0*
_output_shapes
: *
value
B :
F
sub_35Subsub_35/xunstack_20:1*
_output_shapes
: *
T0
6
Neg_10Negsub_35*
_output_shapes
: *
T0
O
floordiv_20/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_20FloorDivNeg_10floordiv_20/y*
_output_shapes
: *
T0
N
Maximum_20/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_20Maximumfloordiv_20Maximum_20/y*
_output_shapes
: *
T0
O
floordiv_21/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_21FloorDivsub_35floordiv_21/y*
T0*
_output_shapes
: 
N
Maximum_21/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_21Maximumfloordiv_21Maximum_21/y*
_output_shapes
: *
T0
J
sub_36/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_36Subsub_36/x
unstack_20*
T0*
_output_shapes
: 
6
Neg_11Negsub_36*
T0*
_output_shapes
: 
O
floordiv_22/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_22FloorDivNeg_11floordiv_22/y*
_output_shapes
: *
T0
N
Maximum_22/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_22Maximumfloordiv_22Maximum_22/y*
_output_shapes
: *
T0
O
floordiv_23/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_23FloorDivsub_36floordiv_23/y*
_output_shapes
: *
T0
N
Maximum_23/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_23Maximumfloordiv_23Maximum_23/y*
_output_shapes
: *
T0
N
Minimum_10/xConst*
value	B :P*
dtype0*
_output_shapes
: 
P

Minimum_10MinimumMinimum_10/x
unstack_20*
T0*
_output_shapes
: 
O
Minimum_11/xConst*
value
B :*
dtype0*
_output_shapes
: 
R

Minimum_11MinimumMinimum_11/xunstack_20:1*
_output_shapes
: *
T0
]
Shape_37Shapecontrol_dependency_20*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_16/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_16/assert_less/LessLessassert_positive_16/ConstShape_37*
T0*
_output_shapes
:
n
$assert_positive_16/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_16/assert_less/AllAll#assert_positive_16/assert_less/Less$assert_positive_16/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_16/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_16/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Ќ
,assert_positive_16/assert_less/Assert/AssertAssert"assert_positive_16/assert_less/All3assert_positive_16/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_38Shapecontrol_dependency_20*
T0*
out_type0*
_output_shapes
:
Z

unstack_21UnpackShape_38*	
num*
T0*

axis *
_output_shapes
: : : 
S
GreaterEqual_40/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_40GreaterEqual
Maximum_20GreaterEqual_40/y*
T0*
_output_shapes
: 
j
Assert_50/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
r
Assert_50/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
a
Assert_50/AssertAssertGreaterEqual_40Assert_50/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_41/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_41GreaterEqual
Maximum_22GreaterEqual_41/y*
_output_shapes
: *
T0
k
Assert_51/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_51/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_51/AssertAssertGreaterEqual_41Assert_51/Assert/data_0*
	summarize*

T
2
N
Greater_10/yConst*
value	B : *
_output_shapes
: *
dtype0
P

Greater_10Greater
Minimum_11Greater_10/y*
_output_shapes
: *
T0
i
Assert_52/ConstConst*
_output_shapes
: *
dtype0**
value!B Btarget_width must be > 0.
q
Assert_52/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
\
Assert_52/AssertAssert
Greater_10Assert_52/Assert/data_0*
	summarize*

T
2
N
Greater_11/yConst*
_output_shapes
: *
dtype0*
value	B : 
P

Greater_11Greater
Minimum_10Greater_11/y*
T0*
_output_shapes
: 
j
Assert_53/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
r
Assert_53/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
\
Assert_53/AssertAssert
Greater_11Assert_53/Assert/data_0*

T
2*
	summarize
F
add_10Add
Minimum_11
Maximum_20*
_output_shapes
: *
T0
V
GreaterEqual_42GreaterEqualunstack_21:1add_10*
T0*
_output_shapes
: 
q
Assert_54/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_54/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_54/AssertAssertGreaterEqual_42Assert_54/Assert/data_0*
	summarize*

T
2
F
add_11Add
Minimum_10
Maximum_22*
T0*
_output_shapes
: 
T
GreaterEqual_43GreaterEqual
unstack_21add_11*
T0*
_output_shapes
: 
r
Assert_55/ConstConst*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
z
Assert_55/Assert/data_0Const*3
value*B( B"height must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_55/AssertAssertGreaterEqual_43Assert_55/Assert/data_0*

T
2*
	summarize
Т
control_dependency_21Identitycontrol_dependency_20-^assert_positive_16/assert_less/Assert/Assert^Assert_50/Assert^Assert_51/Assert^Assert_52/Assert^Assert_53/Assert^Assert_54/Assert^Assert_55/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_5*
T0
L

stack_15/2Const*
_output_shapes
: *
dtype0*
value	B : 
n
stack_15Pack
Maximum_22
Maximum_20
stack_15/2*
T0*

axis *
N*
_output_shapes
:
U

stack_16/2Const*
valueB :
џџџџџџџџџ*
dtype0*
_output_shapes
: 
n
stack_16Pack
Minimum_10
Minimum_11
stack_16/2*
_output_shapes
:*
N*

axis *
T0

Slice_5Slicecontrol_dependency_21stack_15stack_16*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_39ShapeSlice_5*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_17/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
t
#assert_positive_17/assert_less/LessLessassert_positive_17/ConstShape_39*
T0*
_output_shapes
:
n
$assert_positive_17/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_17/assert_less/AllAll#assert_positive_17/assert_less/Less$assert_positive_17/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_17/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_17/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_17/assert_less/Assert/AssertAssert"assert_positive_17/assert_less/All3assert_positive_17/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_40ShapeSlice_5*
out_type0*
_output_shapes
:*
T0
Z

unstack_22UnpackShape_40*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_37/xConst*
value
B :*
_output_shapes
: *
dtype0
D
sub_37Subsub_37/x
Maximum_21*
T0*
_output_shapes
: 
D
sub_38Subsub_37unstack_22:1*
T0*
_output_shapes
: 
J
sub_39/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_39Subsub_39/x
Maximum_23*
T0*
_output_shapes
: 
B
sub_40Subsub_39
unstack_22*
_output_shapes
: *
T0
S
GreaterEqual_44/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_44GreaterEqual
Maximum_23GreaterEqual_44/y*
_output_shapes
: *
T0
j
Assert_56/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
r
Assert_56/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_56/AssertAssertGreaterEqual_44Assert_56/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_45/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_45GreaterEqual
Maximum_21GreaterEqual_45/y*
_output_shapes
: *
T0
i
Assert_57/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_57/Assert/data_0Const**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_57/AssertAssertGreaterEqual_45Assert_57/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_46/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_46GreaterEqualsub_38GreaterEqual_46/y*
T0*
_output_shapes
: 
p
Assert_58/ConstConst*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_58/Assert/data_0Const*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
a
Assert_58/AssertAssertGreaterEqual_46Assert_58/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_47/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_47GreaterEqualsub_40GreaterEqual_47/y*
T0*
_output_shapes
: 
q
Assert_59/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
y
Assert_59/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_59/AssertAssertGreaterEqual_47Assert_59/Assert/data_0*
	summarize*

T
2

control_dependency_22IdentitySlice_5-^assert_positive_17/assert_less/Assert/Assert^Assert_56/Assert^Assert_57/Assert^Assert_58/Assert^Assert_59/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_5*
T0
L

stack_17/4Const*
value	B : *
_output_shapes
: *
dtype0
L

stack_17/5Const*
_output_shapes
: *
dtype0*
value	B : 

stack_17Pack
Maximum_23sub_40
Maximum_21sub_38
stack_17/4
stack_17/5*
N*
T0*
_output_shapes
:*

axis 
a
Reshape_10/shapeConst*
valueB"      *
dtype0*
_output_shapes
:
h

Reshape_10Reshapestack_17Reshape_10/shape*
T0*
_output_shapes

:*
Tshape0
w
Pad_5Padcontrol_dependency_22
Reshape_10*,
_output_shapes
:Pџџџџџџџџџ*
T0*
	Tpaddings0
M
Shape_41ShapePad_5*
_output_shapes
:*
out_type0*
T0
Z

unstack_23UnpackShape_41*

axis *
_output_shapes
: : : *	
num*
T0
y
control_dependency_23IdentityPad_5*
_class

loc:@Pad_5*,
_output_shapes
:Pџџџџџџџџџ*
T0
e
Reshape_11/shapeConst*
_output_shapes
:*
dtype0*!
valueB"P         
z

Reshape_11Reshapecontrol_dependency_23Reshape_11/shape*
T0*
Tshape0*#
_output_shapes
:P
Z
	ToFloat_5Cast
Reshape_11*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_5/yConst*
dtype0*
_output_shapes
: *
valueB
 *  C
R
div_5RealDiv	ToFloat_5div_5/y*
T0*#
_output_shapes
:P
M
sub_41/yConst*
valueB
 *   ?*
dtype0*
_output_shapes
: 
L
sub_41Subdiv_5sub_41/y*
T0*#
_output_shapes
:P
v
shuffle_batch_5/ConstConst*
dtype0*
_output_shapes
:*-
value$B""                      №?
Y
shuffle_batch_5/Const_1Const*
value	B
 Z*
_output_shapes
: *
dtype0

ј
$shuffle_batch_5/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
seed2 *
	container *
shared_name *

seed *
_output_shapes
: *
component_types
2*
capacity*
min_after_dequeue

z
shuffle_batch_5/cond/SwitchSwitchshuffle_batch_5/Const_1shuffle_batch_5/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_5/cond/switch_tIdentityshuffle_batch_5/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_5/cond/switch_fIdentityshuffle_batch_5/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_5/cond/pred_idIdentityshuffle_batch_5/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_5/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_5/random_shuffle_queueshuffle_batch_5/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_5/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_41shuffle_batch_5/cond/pred_id*2
_output_shapes 
:P:P*
_class
loc:@sub_41*
T0
Ю
:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_5/Constshuffle_batch_5/cond/pred_id*(
_class
loc:@shuffle_batch_5/Const* 
_output_shapes
::*
T0
­
1shuffle_batch_5/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_5/cond/control_dependencyIdentityshuffle_batch_5/cond/switch_t2^shuffle_batch_5/cond/random_shuffle_queue_enqueue*0
_class&
$"loc:@shuffle_batch_5/cond/switch_t*
_output_shapes
: *
T0

A
shuffle_batch_5/cond/NoOpNoOp^shuffle_batch_5/cond/switch_f
У
)shuffle_batch_5/cond/control_dependency_1Identityshuffle_batch_5/cond/switch_f^shuffle_batch_5/cond/NoOp*
T0
*0
_class&
$"loc:@shuffle_batch_5/cond/switch_f*
_output_shapes
: 
Ѓ
shuffle_batch_5/cond/MergeMerge)shuffle_batch_5/cond/control_dependency_1'shuffle_batch_5/cond/control_dependency*
N*
T0
*
_output_shapes
: : 

*shuffle_batch_5/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_5/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_5/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_5/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_5/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_5/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_5/sub/yConst*
_output_shapes
: *
dtype0*
value	B :

}
shuffle_batch_5/subSub)shuffle_batch_5/random_shuffle_queue_Sizeshuffle_batch_5/sub/y*
T0*
_output_shapes
: 
[
shuffle_batch_5/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
s
shuffle_batch_5/MaximumMaximumshuffle_batch_5/Maximum/xshuffle_batch_5/sub*
T0*
_output_shapes
: 
e
shuffle_batch_5/CastCastshuffle_batch_5/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_5/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_5/mulMulshuffle_batch_5/Castshuffle_batch_5/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_5/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_5/fraction_over_10_of_12_full*
_output_shapes
: *
dtype0
Є
+shuffle_batch_5/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_5/fraction_over_10_of_12_full/tagsshuffle_batch_5/mul*
_output_shapes
: *
T0
S
shuffle_batch_5/nConst*
value	B :*
dtype0*
_output_shapes
: 
Ч
shuffle_batch_5QueueDequeueManyV2$shuffle_batch_5/random_shuffle_queueshuffle_batch_5/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
O
concat_2/axisConst*
value	B : *
dtype0*
_output_shapes
: 

concat_2ConcatV2shuffle_batch_3shuffle_batch_4shuffle_batch_5concat_2/axis*'
_output_shapes
:P*
N*
T0*

Tidx0
O
concat_3/axisConst*
value	B : *
dtype0*
_output_shapes
: 

concat_3ConcatV2shuffle_batch_3:1shuffle_batch_4:1shuffle_batch_5:1concat_3/axis*
_output_shapes

:*
T0*

Tidx0*
N
w
*matching_filenames_6/MatchingFiles/patternConst*
valueB BTest/0/*.jpg*
_output_shapes
: *
dtype0

"matching_filenames_6/MatchingFilesMatchingFiles*matching_filenames_6/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_6
VariableV2*
_output_shapes
:*
	container *
dtype0*
shared_name *
shape:
п
matching_filenames_6/AssignAssignmatching_filenames_6"matching_filenames_6/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_6

matching_filenames_6/readIdentitymatching_filenames_6*
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_6
i
input_producer_6/SizeSizematching_filenames_6/read*
T0*
_output_shapes
: *
out_type0
\
input_producer_6/Greater/yConst*
_output_shapes
: *
dtype0*
value	B : 
w
input_producer_6/GreaterGreaterinput_producer_6/Sizeinput_producer_6/Greater/y*
T0*
_output_shapes
: 

input_producer_6/Assert/ConstConst*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_6/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
dtype0*
_output_shapes
: 

input_producer_6/Assert/AssertAssertinput_producer_6/Greater%input_producer_6/Assert/Assert/data_0*
	summarize*

T
2

input_producer_6/IdentityIdentitymatching_filenames_6/read^input_producer_6/Assert/Assert*
T0*
_output_shapes
:

input_producer_6FIFOQueueV2*
shapes
: *
_output_shapes
: *
component_types
2*
shared_name *
	container *
capacity 
Ё
-input_producer_6/input_producer_6_EnqueueManyQueueEnqueueManyV2input_producer_6input_producer_6/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_6/input_producer_6_CloseQueueCloseV2input_producer_6*
cancel_pending_enqueues( 
j
)input_producer_6/input_producer_6_Close_1QueueCloseV2input_producer_6*
cancel_pending_enqueues(
_
&input_producer_6/input_producer_6_SizeQueueSizeV2input_producer_6*
_output_shapes
: 
u
input_producer_6/CastCast&input_producer_6/input_producer_6_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_6/mul/yConst*
valueB
 *   =*
dtype0*
_output_shapes
: 
k
input_producer_6/mulMulinput_producer_6/Castinput_producer_6/mul/y*
T0*
_output_shapes
: 

)input_producer_6/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_6/fraction_of_32_full*
_output_shapes
: *
dtype0

$input_producer_6/fraction_of_32_fullScalarSummary)input_producer_6/fraction_of_32_full/tagsinput_producer_6/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_6WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_6ReaderReadV2WholeFileReaderV2_6input_producer_6*
_output_shapes
: : 
ь
DecodeJpeg_6
DecodeJpegReaderReadV2_6:1*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
try_recover_truncated( *
fancy_upscaling(*
acceptable_fraction%  ?*
channels *

dct_method 
T
Shape_42ShapeDecodeJpeg_6*
out_type0*
_output_shapes
:*
T0
Z
assert_positive_18/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_18/assert_less/LessLessassert_positive_18/ConstShape_42*
_output_shapes
:*
T0
n
$assert_positive_18/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
Љ
"assert_positive_18/assert_less/AllAll#assert_positive_18/assert_less/Less$assert_positive_18/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_18/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_18/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_18/assert_less/Assert/AssertAssert"assert_positive_18/assert_less/All3assert_positive_18/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_24IdentityDecodeJpeg_6-^assert_positive_18/assert_less/Assert/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_6
]
Shape_43Shapecontrol_dependency_24*
out_type0*
_output_shapes
:*
T0
Z

unstack_24UnpackShape_43*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_42/xConst*
_output_shapes
: *
dtype0*
value
B :
F
sub_42Subsub_42/xunstack_24:1*
T0*
_output_shapes
: 
6
Neg_12Negsub_42*
_output_shapes
: *
T0
O
floordiv_24/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_24FloorDivNeg_12floordiv_24/y*
_output_shapes
: *
T0
N
Maximum_24/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_24Maximumfloordiv_24Maximum_24/y*
_output_shapes
: *
T0
O
floordiv_25/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_25FloorDivsub_42floordiv_25/y*
T0*
_output_shapes
: 
N
Maximum_25/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_25Maximumfloordiv_25Maximum_25/y*
_output_shapes
: *
T0
J
sub_43/xConst*
value	B :P*
_output_shapes
: *
dtype0
D
sub_43Subsub_43/x
unstack_24*
T0*
_output_shapes
: 
6
Neg_13Negsub_43*
T0*
_output_shapes
: 
O
floordiv_26/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_26FloorDivNeg_13floordiv_26/y*
T0*
_output_shapes
: 
N
Maximum_26/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_26Maximumfloordiv_26Maximum_26/y*
_output_shapes
: *
T0
O
floordiv_27/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_27FloorDivsub_43floordiv_27/y*
_output_shapes
: *
T0
N
Maximum_27/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_27Maximumfloordiv_27Maximum_27/y*
_output_shapes
: *
T0
N
Minimum_12/xConst*
dtype0*
_output_shapes
: *
value	B :P
P

Minimum_12MinimumMinimum_12/x
unstack_24*
_output_shapes
: *
T0
O
Minimum_13/xConst*
value
B :*
_output_shapes
: *
dtype0
R

Minimum_13MinimumMinimum_13/xunstack_24:1*
T0*
_output_shapes
: 
]
Shape_44Shapecontrol_dependency_24*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_19/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_19/assert_less/LessLessassert_positive_19/ConstShape_44*
T0*
_output_shapes
:
n
$assert_positive_19/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_19/assert_less/AllAll#assert_positive_19/assert_less/Less$assert_positive_19/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_19/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_19/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_19/assert_less/Assert/AssertAssert"assert_positive_19/assert_less/All3assert_positive_19/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_45Shapecontrol_dependency_24*
_output_shapes
:*
out_type0*
T0
Z

unstack_25UnpackShape_45*

axis *
_output_shapes
: : : *	
num*
T0
S
GreaterEqual_48/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_48GreaterEqual
Maximum_24GreaterEqual_48/y*
_output_shapes
: *
T0
j
Assert_60/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
r
Assert_60/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_60/AssertAssertGreaterEqual_48Assert_60/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_49/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_49GreaterEqual
Maximum_26GreaterEqual_49/y*
T0*
_output_shapes
: 
k
Assert_61/ConstConst*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
s
Assert_61/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_61/AssertAssertGreaterEqual_49Assert_61/Assert/data_0*

T
2*
	summarize
N
Greater_12/yConst*
_output_shapes
: *
dtype0*
value	B : 
P

Greater_12Greater
Minimum_13Greater_12/y*
_output_shapes
: *
T0
i
Assert_62/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
q
Assert_62/Assert/data_0Const*
_output_shapes
: *
dtype0**
value!B Btarget_width must be > 0.
\
Assert_62/AssertAssert
Greater_12Assert_62/Assert/data_0*

T
2*
	summarize
N
Greater_13/yConst*
value	B : *
_output_shapes
: *
dtype0
P

Greater_13Greater
Minimum_12Greater_13/y*
T0*
_output_shapes
: 
j
Assert_63/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
r
Assert_63/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
\
Assert_63/AssertAssert
Greater_13Assert_63/Assert/data_0*
	summarize*

T
2
F
add_12Add
Minimum_13
Maximum_24*
_output_shapes
: *
T0
V
GreaterEqual_50GreaterEqualunstack_25:1add_12*
_output_shapes
: *
T0
q
Assert_64/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
y
Assert_64/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
a
Assert_64/AssertAssertGreaterEqual_50Assert_64/Assert/data_0*
	summarize*

T
2
F
add_13Add
Minimum_12
Maximum_26*
T0*
_output_shapes
: 
T
GreaterEqual_51GreaterEqual
unstack_25add_13*
_output_shapes
: *
T0
r
Assert_65/ConstConst*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
z
Assert_65/Assert/data_0Const*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_65/AssertAssertGreaterEqual_51Assert_65/Assert/data_0*

T
2*
	summarize
Т
control_dependency_25Identitycontrol_dependency_24-^assert_positive_19/assert_less/Assert/Assert^Assert_60/Assert^Assert_61/Assert^Assert_62/Assert^Assert_63/Assert^Assert_64/Assert^Assert_65/Assert*
_class
loc:@DecodeJpeg_6*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_18/2Const*
value	B : *
dtype0*
_output_shapes
: 
n
stack_18Pack
Maximum_26
Maximum_24
stack_18/2*

axis *
_output_shapes
:*
T0*
N
U

stack_19/2Const*
valueB :
џџџџџџџџџ*
dtype0*
_output_shapes
: 
n
stack_19Pack
Minimum_12
Minimum_13
stack_19/2*
_output_shapes
:*
N*

axis *
T0

Slice_6Slicecontrol_dependency_25stack_18stack_19*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_46ShapeSlice_6*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_20/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_20/assert_less/LessLessassert_positive_20/ConstShape_46*
T0*
_output_shapes
:
n
$assert_positive_20/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_20/assert_less/AllAll#assert_positive_20/assert_less/Less$assert_positive_20/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_20/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_20/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_20/assert_less/Assert/AssertAssert"assert_positive_20/assert_less/All3assert_positive_20/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_47ShapeSlice_6*
T0*
out_type0*
_output_shapes
:
Z

unstack_26UnpackShape_47*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_44/xConst*
value
B :*
_output_shapes
: *
dtype0
D
sub_44Subsub_44/x
Maximum_25*
T0*
_output_shapes
: 
D
sub_45Subsub_44unstack_26:1*
T0*
_output_shapes
: 
J
sub_46/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_46Subsub_46/x
Maximum_27*
_output_shapes
: *
T0
B
sub_47Subsub_46
unstack_26*
T0*
_output_shapes
: 
S
GreaterEqual_52/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_52GreaterEqual
Maximum_27GreaterEqual_52/y*
_output_shapes
: *
T0
j
Assert_66/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
r
Assert_66/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
a
Assert_66/AssertAssertGreaterEqual_52Assert_66/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_53/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_53GreaterEqual
Maximum_25GreaterEqual_53/y*
T0*
_output_shapes
: 
i
Assert_67/ConstConst**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
q
Assert_67/Assert/data_0Const**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_67/AssertAssertGreaterEqual_53Assert_67/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_54/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_54GreaterEqualsub_45GreaterEqual_54/y*
_output_shapes
: *
T0
p
Assert_68/ConstConst*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
x
Assert_68/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_68/AssertAssertGreaterEqual_54Assert_68/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_55/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_55GreaterEqualsub_47GreaterEqual_55/y*
T0*
_output_shapes
: 
q
Assert_69/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
y
Assert_69/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_69/AssertAssertGreaterEqual_55Assert_69/Assert/data_0*

T
2*
	summarize

control_dependency_26IdentitySlice_6-^assert_positive_20/assert_less/Assert/Assert^Assert_66/Assert^Assert_67/Assert^Assert_68/Assert^Assert_69/Assert*
T0*
_class
loc:@Slice_6*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_20/4Const*
value	B : *
_output_shapes
: *
dtype0
L

stack_20/5Const*
dtype0*
_output_shapes
: *
value	B : 

stack_20Pack
Maximum_27sub_47
Maximum_25sub_45
stack_20/4
stack_20/5*
_output_shapes
:*
N*

axis *
T0
a
Reshape_12/shapeConst*
_output_shapes
:*
dtype0*
valueB"      
h

Reshape_12Reshapestack_20Reshape_12/shape*
T0*
_output_shapes

:*
Tshape0
w
Pad_6Padcontrol_dependency_26
Reshape_12*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_48ShapePad_6*
out_type0*
_output_shapes
:*
T0
Z

unstack_27UnpackShape_48*	
num*
T0*

axis *
_output_shapes
: : : 
y
control_dependency_27IdentityPad_6*
T0*
_class

loc:@Pad_6*,
_output_shapes
:Pџџџџџџџџџ
e
Reshape_13/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
z

Reshape_13Reshapecontrol_dependency_27Reshape_13/shape*
T0*
Tshape0*#
_output_shapes
:P
Z
	ToFloat_6Cast
Reshape_13*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_6/yConst*
_output_shapes
: *
dtype0*
valueB
 *  C
R
div_6RealDiv	ToFloat_6div_6/y*#
_output_shapes
:P*
T0
M
sub_48/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
L
sub_48Subdiv_6sub_48/y*#
_output_shapes
:P*
T0
v
shuffle_batch_6/ConstConst*
_output_shapes
:*
dtype0*-
value$B""      №?                
Y
shuffle_batch_6/Const_1Const*
value	B
 Z*
dtype0
*
_output_shapes
: 
ј
$shuffle_batch_6/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
	container *
seed2 *

seed *
_output_shapes
: *
component_types
2*
min_after_dequeue
*
capacity*
shared_name 
z
shuffle_batch_6/cond/SwitchSwitchshuffle_batch_6/Const_1shuffle_batch_6/Const_1*
T0
*
_output_shapes
: : 
i
shuffle_batch_6/cond/switch_tIdentityshuffle_batch_6/cond/Switch:1*
_output_shapes
: *
T0

g
shuffle_batch_6/cond/switch_fIdentityshuffle_batch_6/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_6/cond/pred_idIdentityshuffle_batch_6/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_6/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_6/random_shuffle_queueshuffle_batch_6/cond/pred_id*7
_class-
+)loc:@shuffle_batch_6/random_shuffle_queue*
_output_shapes
: : *
T0
Т
:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_48shuffle_batch_6/cond/pred_id*
T0*
_class
loc:@sub_48*2
_output_shapes 
:P:P
Ю
:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_6/Constshuffle_batch_6/cond/pred_id*
T0*(
_class
loc:@shuffle_batch_6/Const* 
_output_shapes
::
­
1shuffle_batch_6/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_6/cond/control_dependencyIdentityshuffle_batch_6/cond/switch_t2^shuffle_batch_6/cond/random_shuffle_queue_enqueue*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_6/cond/switch_t
A
shuffle_batch_6/cond/NoOpNoOp^shuffle_batch_6/cond/switch_f
У
)shuffle_batch_6/cond/control_dependency_1Identityshuffle_batch_6/cond/switch_f^shuffle_batch_6/cond/NoOp*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_6/cond/switch_f
Ѓ
shuffle_batch_6/cond/MergeMerge)shuffle_batch_6/cond/control_dependency_1'shuffle_batch_6/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_6/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_6/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_6/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_6/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_6/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_6/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_6/sub/yConst*
value	B :
*
_output_shapes
: *
dtype0
}
shuffle_batch_6/subSub)shuffle_batch_6/random_shuffle_queue_Sizeshuffle_batch_6/sub/y*
T0*
_output_shapes
: 
[
shuffle_batch_6/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_6/MaximumMaximumshuffle_batch_6/Maximum/xshuffle_batch_6/sub*
T0*
_output_shapes
: 
e
shuffle_batch_6/CastCastshuffle_batch_6/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_6/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_6/mulMulshuffle_batch_6/Castshuffle_batch_6/mul/y*
_output_shapes
: *
T0

0shuffle_batch_6/fraction_over_10_of_12_full/tagsConst*
dtype0*
_output_shapes
: *<
value3B1 B+shuffle_batch_6/fraction_over_10_of_12_full
Є
+shuffle_batch_6/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_6/fraction_over_10_of_12_full/tagsshuffle_batch_6/mul*
T0*
_output_shapes
: 
S
shuffle_batch_6/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_6QueueDequeueManyV2$shuffle_batch_6/random_shuffle_queueshuffle_batch_6/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
w
*matching_filenames_7/MatchingFiles/patternConst*
valueB BTest/1/*.jpg*
dtype0*
_output_shapes
: 

"matching_filenames_7/MatchingFilesMatchingFiles*matching_filenames_7/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_7
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_7/AssignAssignmatching_filenames_7"matching_filenames_7/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_7

matching_filenames_7/readIdentitymatching_filenames_7*
T0*'
_class
loc:@matching_filenames_7*
_output_shapes
:
i
input_producer_7/SizeSizematching_filenames_7/read*
out_type0*
_output_shapes
: *
T0
\
input_producer_7/Greater/yConst*
value	B : *
_output_shapes
: *
dtype0
w
input_producer_7/GreaterGreaterinput_producer_7/Sizeinput_producer_7/Greater/y*
T0*
_output_shapes
: 

input_producer_7/Assert/ConstConst*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_7/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

input_producer_7/Assert/AssertAssertinput_producer_7/Greater%input_producer_7/Assert/Assert/data_0*
	summarize*

T
2

input_producer_7/IdentityIdentitymatching_filenames_7/read^input_producer_7/Assert/Assert*
_output_shapes
:*
T0

input_producer_7FIFOQueueV2*
shapes
: *
	container *
_output_shapes
: *
component_types
2*
capacity *
shared_name 
Ё
-input_producer_7/input_producer_7_EnqueueManyQueueEnqueueManyV2input_producer_7input_producer_7/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_7/input_producer_7_CloseQueueCloseV2input_producer_7*
cancel_pending_enqueues( 
j
)input_producer_7/input_producer_7_Close_1QueueCloseV2input_producer_7*
cancel_pending_enqueues(
_
&input_producer_7/input_producer_7_SizeQueueSizeV2input_producer_7*
_output_shapes
: 
u
input_producer_7/CastCast&input_producer_7/input_producer_7_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_7/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *   =
k
input_producer_7/mulMulinput_producer_7/Castinput_producer_7/mul/y*
T0*
_output_shapes
: 

)input_producer_7/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_7/fraction_of_32_full

$input_producer_7/fraction_of_32_fullScalarSummary)input_producer_7/fraction_of_32_full/tagsinput_producer_7/mul*
T0*
_output_shapes
: 
d
WholeFileReaderV2_7WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
_
ReaderReadV2_7ReaderReadV2WholeFileReaderV2_7input_producer_7*
_output_shapes
: : 
ь
DecodeJpeg_7
DecodeJpegReaderReadV2_7:1*
fancy_upscaling(*

dct_method *
try_recover_truncated( *
channels *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
acceptable_fraction%  ?
T
Shape_49ShapeDecodeJpeg_7*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_21/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_21/assert_less/LessLessassert_positive_21/ConstShape_49*
_output_shapes
:*
T0
n
$assert_positive_21/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
Љ
"assert_positive_21/assert_less/AllAll#assert_positive_21/assert_less/Less$assert_positive_21/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_21/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_21/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_21/assert_less/Assert/AssertAssert"assert_positive_21/assert_less/All3assert_positive_21/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Ч
control_dependency_28IdentityDecodeJpeg_7-^assert_positive_21/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg_7*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
]
Shape_50Shapecontrol_dependency_28*
out_type0*
_output_shapes
:*
T0
Z

unstack_28UnpackShape_50*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_49/xConst*
value
B :*
_output_shapes
: *
dtype0
F
sub_49Subsub_49/xunstack_28:1*
T0*
_output_shapes
: 
6
Neg_14Negsub_49*
T0*
_output_shapes
: 
O
floordiv_28/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_28FloorDivNeg_14floordiv_28/y*
_output_shapes
: *
T0
N
Maximum_28/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_28Maximumfloordiv_28Maximum_28/y*
T0*
_output_shapes
: 
O
floordiv_29/yConst*
_output_shapes
: *
dtype0*
value	B :
O
floordiv_29FloorDivsub_49floordiv_29/y*
_output_shapes
: *
T0
N
Maximum_29/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_29Maximumfloordiv_29Maximum_29/y*
_output_shapes
: *
T0
J
sub_50/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_50Subsub_50/x
unstack_28*
_output_shapes
: *
T0
6
Neg_15Negsub_50*
_output_shapes
: *
T0
O
floordiv_30/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_30FloorDivNeg_15floordiv_30/y*
T0*
_output_shapes
: 
N
Maximum_30/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_30Maximumfloordiv_30Maximum_30/y*
_output_shapes
: *
T0
O
floordiv_31/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_31FloorDivsub_50floordiv_31/y*
T0*
_output_shapes
: 
N
Maximum_31/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_31Maximumfloordiv_31Maximum_31/y*
_output_shapes
: *
T0
N
Minimum_14/xConst*
dtype0*
_output_shapes
: *
value	B :P
P

Minimum_14MinimumMinimum_14/x
unstack_28*
_output_shapes
: *
T0
O
Minimum_15/xConst*
_output_shapes
: *
dtype0*
value
B :
R

Minimum_15MinimumMinimum_15/xunstack_28:1*
_output_shapes
: *
T0
]
Shape_51Shapecontrol_dependency_28*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_22/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_22/assert_less/LessLessassert_positive_22/ConstShape_51*
_output_shapes
:*
T0
n
$assert_positive_22/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
Љ
"assert_positive_22/assert_less/AllAll#assert_positive_22/assert_less/Less$assert_positive_22/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_22/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_22/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_22/assert_less/Assert/AssertAssert"assert_positive_22/assert_less/All3assert_positive_22/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_52Shapecontrol_dependency_28*
_output_shapes
:*
out_type0*
T0
Z

unstack_29UnpackShape_52*
_output_shapes
: : : *

axis *	
num*
T0
S
GreaterEqual_56/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_56GreaterEqual
Maximum_28GreaterEqual_56/y*
_output_shapes
: *
T0
j
Assert_70/ConstConst*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
r
Assert_70/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_70/AssertAssertGreaterEqual_56Assert_70/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_57/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_57GreaterEqual
Maximum_30GreaterEqual_57/y*
_output_shapes
: *
T0
k
Assert_71/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_71/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_71/AssertAssertGreaterEqual_57Assert_71/Assert/data_0*

T
2*
	summarize
N
Greater_14/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_14Greater
Minimum_15Greater_14/y*
T0*
_output_shapes
: 
i
Assert_72/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
q
Assert_72/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
\
Assert_72/AssertAssert
Greater_14Assert_72/Assert/data_0*

T
2*
	summarize
N
Greater_15/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_15Greater
Minimum_14Greater_15/y*
_output_shapes
: *
T0
j
Assert_73/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
r
Assert_73/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
\
Assert_73/AssertAssert
Greater_15Assert_73/Assert/data_0*
	summarize*

T
2
F
add_14Add
Minimum_15
Maximum_28*
T0*
_output_shapes
: 
V
GreaterEqual_58GreaterEqualunstack_29:1add_14*
_output_shapes
: *
T0
q
Assert_74/ConstConst*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
y
Assert_74/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_74/AssertAssertGreaterEqual_58Assert_74/Assert/data_0*

T
2*
	summarize
F
add_15Add
Minimum_14
Maximum_30*
_output_shapes
: *
T0
T
GreaterEqual_59GreaterEqual
unstack_29add_15*
T0*
_output_shapes
: 
r
Assert_75/ConstConst*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
z
Assert_75/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_75/AssertAssertGreaterEqual_59Assert_75/Assert/data_0*

T
2*
	summarize
Т
control_dependency_29Identitycontrol_dependency_28-^assert_positive_22/assert_less/Assert/Assert^Assert_70/Assert^Assert_71/Assert^Assert_72/Assert^Assert_73/Assert^Assert_74/Assert^Assert_75/Assert*
T0*
_class
loc:@DecodeJpeg_7*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_21/2Const*
value	B : *
_output_shapes
: *
dtype0
n
stack_21Pack
Maximum_30
Maximum_28
stack_21/2*
T0*

axis *
N*
_output_shapes
:
U

stack_22/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
n
stack_22Pack
Minimum_14
Minimum_15
stack_22/2*
_output_shapes
:*
N*

axis *
T0

Slice_7Slicecontrol_dependency_29stack_21stack_22*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_53ShapeSlice_7*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_23/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_23/assert_less/LessLessassert_positive_23/ConstShape_53*
_output_shapes
:*
T0
n
$assert_positive_23/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_23/assert_less/AllAll#assert_positive_23/assert_less/Less$assert_positive_23/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_23/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_23/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_23/assert_less/Assert/AssertAssert"assert_positive_23/assert_less/All3assert_positive_23/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_54ShapeSlice_7*
T0*
_output_shapes
:*
out_type0
Z

unstack_30UnpackShape_54*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_51/xConst*
value
B :*
dtype0*
_output_shapes
: 
D
sub_51Subsub_51/x
Maximum_29*
_output_shapes
: *
T0
D
sub_52Subsub_51unstack_30:1*
T0*
_output_shapes
: 
J
sub_53/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_53Subsub_53/x
Maximum_31*
T0*
_output_shapes
: 
B
sub_54Subsub_53
unstack_30*
T0*
_output_shapes
: 
S
GreaterEqual_60/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_60GreaterEqual
Maximum_31GreaterEqual_60/y*
T0*
_output_shapes
: 
j
Assert_76/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
r
Assert_76/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
a
Assert_76/AssertAssertGreaterEqual_60Assert_76/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_61/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_61GreaterEqual
Maximum_29GreaterEqual_61/y*
T0*
_output_shapes
: 
i
Assert_77/ConstConst*
_output_shapes
: *
dtype0**
value!B Boffset_width must be >= 0
q
Assert_77/Assert/data_0Const**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_77/AssertAssertGreaterEqual_61Assert_77/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_62/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_62GreaterEqualsub_52GreaterEqual_62/y*
T0*
_output_shapes
: 
p
Assert_78/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
x
Assert_78/Assert/data_0Const*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
a
Assert_78/AssertAssertGreaterEqual_62Assert_78/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_63/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_63GreaterEqualsub_54GreaterEqual_63/y*
T0*
_output_shapes
: 
q
Assert_79/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
y
Assert_79/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_79/AssertAssertGreaterEqual_63Assert_79/Assert/data_0*

T
2*
	summarize

control_dependency_30IdentitySlice_7-^assert_positive_23/assert_less/Assert/Assert^Assert_76/Assert^Assert_77/Assert^Assert_78/Assert^Assert_79/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_7*
T0
L

stack_23/4Const*
dtype0*
_output_shapes
: *
value	B : 
L

stack_23/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_23Pack
Maximum_31sub_54
Maximum_29sub_52
stack_23/4
stack_23/5*
N*
T0*
_output_shapes
:*

axis 
a
Reshape_14/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
h

Reshape_14Reshapestack_23Reshape_14/shape*
T0*
Tshape0*
_output_shapes

:
w
Pad_7Padcontrol_dependency_30
Reshape_14*,
_output_shapes
:Pџџџџџџџџџ*
	Tpaddings0*
T0
M
Shape_55ShapePad_7*
out_type0*
_output_shapes
:*
T0
Z

unstack_31UnpackShape_55*	
num*
T0*
_output_shapes
: : : *

axis 
y
control_dependency_31IdentityPad_7*
_class

loc:@Pad_7*,
_output_shapes
:Pџџџџџџџџџ*
T0
e
Reshape_15/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
z

Reshape_15Reshapecontrol_dependency_31Reshape_15/shape*
Tshape0*#
_output_shapes
:P*
T0
Z
	ToFloat_7Cast
Reshape_15*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_7/yConst*
_output_shapes
: *
dtype0*
valueB
 *  C
R
div_7RealDiv	ToFloat_7div_7/y*#
_output_shapes
:P*
T0
M
sub_55/yConst*
_output_shapes
: *
dtype0*
valueB
 *   ?
L
sub_55Subdiv_7sub_55/y*#
_output_shapes
:P*
T0
v
shuffle_batch_7/ConstConst*-
value$B""              №?        *
dtype0*
_output_shapes
:
Y
shuffle_batch_7/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_7/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*

seed *
shared_name *
capacity*
min_after_dequeue
*
seed2 *
	container *
_output_shapes
: *
component_types
2
z
shuffle_batch_7/cond/SwitchSwitchshuffle_batch_7/Const_1shuffle_batch_7/Const_1*
T0
*
_output_shapes
: : 
i
shuffle_batch_7/cond/switch_tIdentityshuffle_batch_7/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_7/cond/switch_fIdentityshuffle_batch_7/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_7/cond/pred_idIdentityshuffle_batch_7/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_7/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_7/random_shuffle_queueshuffle_batch_7/cond/pred_id*
_output_shapes
: : *7
_class-
+)loc:@shuffle_batch_7/random_shuffle_queue*
T0
Т
:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_55shuffle_batch_7/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_55
Ю
:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_7/Constshuffle_batch_7/cond/pred_id* 
_output_shapes
::*(
_class
loc:@shuffle_batch_7/Const*
T0
­
1shuffle_batch_7/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_7/cond/control_dependencyIdentityshuffle_batch_7/cond/switch_t2^shuffle_batch_7/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_7/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_7/cond/NoOpNoOp^shuffle_batch_7/cond/switch_f
У
)shuffle_batch_7/cond/control_dependency_1Identityshuffle_batch_7/cond/switch_f^shuffle_batch_7/cond/NoOp*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_7/cond/switch_f*
T0

Ѓ
shuffle_batch_7/cond/MergeMerge)shuffle_batch_7/cond/control_dependency_1'shuffle_batch_7/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_7/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_7/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_7/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_7/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_7/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_7/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_7/sub/yConst*
dtype0*
_output_shapes
: *
value	B :

}
shuffle_batch_7/subSub)shuffle_batch_7/random_shuffle_queue_Sizeshuffle_batch_7/sub/y*
T0*
_output_shapes
: 
[
shuffle_batch_7/Maximum/xConst*
dtype0*
_output_shapes
: *
value	B : 
s
shuffle_batch_7/MaximumMaximumshuffle_batch_7/Maximum/xshuffle_batch_7/sub*
T0*
_output_shapes
: 
e
shuffle_batch_7/CastCastshuffle_batch_7/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_7/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *ЋЊЊ=
h
shuffle_batch_7/mulMulshuffle_batch_7/Castshuffle_batch_7/mul/y*
_output_shapes
: *
T0

0shuffle_batch_7/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_7/fraction_over_10_of_12_full*
_output_shapes
: *
dtype0
Є
+shuffle_batch_7/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_7/fraction_over_10_of_12_full/tagsshuffle_batch_7/mul*
_output_shapes
: *
T0
S
shuffle_batch_7/nConst*
_output_shapes
: *
dtype0*
value	B :
Ч
shuffle_batch_7QueueDequeueManyV2$shuffle_batch_7/random_shuffle_queueshuffle_batch_7/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
w
*matching_filenames_8/MatchingFiles/patternConst*
dtype0*
_output_shapes
: *
valueB BTest/2/*.jpg

"matching_filenames_8/MatchingFilesMatchingFiles*matching_filenames_8/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_8
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_8/AssignAssignmatching_filenames_8"matching_filenames_8/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_8

matching_filenames_8/readIdentitymatching_filenames_8*'
_class
loc:@matching_filenames_8*
_output_shapes
:*
T0
i
input_producer_8/SizeSizematching_filenames_8/read*
out_type0*
_output_shapes
: *
T0
\
input_producer_8/Greater/yConst*
_output_shapes
: *
dtype0*
value	B : 
w
input_producer_8/GreaterGreaterinput_producer_8/Sizeinput_producer_8/Greater/y*
_output_shapes
: *
T0

input_producer_8/Assert/ConstConst*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_8/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_8/Assert/AssertAssertinput_producer_8/Greater%input_producer_8/Assert/Assert/data_0*
	summarize*

T
2

input_producer_8/IdentityIdentitymatching_filenames_8/read^input_producer_8/Assert/Assert*
T0*
_output_shapes
:

input_producer_8FIFOQueueV2*
shapes
: *
	container *
_output_shapes
: *
component_types
2*
capacity *
shared_name 
Ё
-input_producer_8/input_producer_8_EnqueueManyQueueEnqueueManyV2input_producer_8input_producer_8/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_8/input_producer_8_CloseQueueCloseV2input_producer_8*
cancel_pending_enqueues( 
j
)input_producer_8/input_producer_8_Close_1QueueCloseV2input_producer_8*
cancel_pending_enqueues(
_
&input_producer_8/input_producer_8_SizeQueueSizeV2input_producer_8*
_output_shapes
: 
u
input_producer_8/CastCast&input_producer_8/input_producer_8_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_8/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_8/mulMulinput_producer_8/Castinput_producer_8/mul/y*
T0*
_output_shapes
: 

)input_producer_8/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_8/fraction_of_32_full*
_output_shapes
: *
dtype0

$input_producer_8/fraction_of_32_fullScalarSummary)input_producer_8/fraction_of_32_full/tagsinput_producer_8/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_8WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_8ReaderReadV2WholeFileReaderV2_8input_producer_8*
_output_shapes
: : 
ь
DecodeJpeg_8
DecodeJpegReaderReadV2_8:1*
acceptable_fraction%  ?*

dct_method *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
fancy_upscaling(*
channels *
try_recover_truncated( 
T
Shape_56ShapeDecodeJpeg_8*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_24/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_24/assert_less/LessLessassert_positive_24/ConstShape_56*
T0*
_output_shapes
:
n
$assert_positive_24/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
Љ
"assert_positive_24/assert_less/AllAll#assert_positive_24/assert_less/Less$assert_positive_24/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_24/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_24/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Ќ
,assert_positive_24/assert_less/Assert/AssertAssert"assert_positive_24/assert_less/All3assert_positive_24/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_32IdentityDecodeJpeg_8-^assert_positive_24/assert_less/Assert/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_8*
T0
]
Shape_57Shapecontrol_dependency_32*
_output_shapes
:*
out_type0*
T0
Z

unstack_32UnpackShape_57*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_56/xConst*
_output_shapes
: *
dtype0*
value
B :
F
sub_56Subsub_56/xunstack_32:1*
_output_shapes
: *
T0
6
Neg_16Negsub_56*
_output_shapes
: *
T0
O
floordiv_32/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_32FloorDivNeg_16floordiv_32/y*
_output_shapes
: *
T0
N
Maximum_32/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_32Maximumfloordiv_32Maximum_32/y*
_output_shapes
: *
T0
O
floordiv_33/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_33FloorDivsub_56floordiv_33/y*
T0*
_output_shapes
: 
N
Maximum_33/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_33Maximumfloordiv_33Maximum_33/y*
_output_shapes
: *
T0
J
sub_57/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_57Subsub_57/x
unstack_32*
_output_shapes
: *
T0
6
Neg_17Negsub_57*
T0*
_output_shapes
: 
O
floordiv_34/yConst*
_output_shapes
: *
dtype0*
value	B :
O
floordiv_34FloorDivNeg_17floordiv_34/y*
T0*
_output_shapes
: 
N
Maximum_34/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_34Maximumfloordiv_34Maximum_34/y*
T0*
_output_shapes
: 
O
floordiv_35/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_35FloorDivsub_57floordiv_35/y*
_output_shapes
: *
T0
N
Maximum_35/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_35Maximumfloordiv_35Maximum_35/y*
_output_shapes
: *
T0
N
Minimum_16/xConst*
dtype0*
_output_shapes
: *
value	B :P
P

Minimum_16MinimumMinimum_16/x
unstack_32*
T0*
_output_shapes
: 
O
Minimum_17/xConst*
_output_shapes
: *
dtype0*
value
B :
R

Minimum_17MinimumMinimum_17/xunstack_32:1*
T0*
_output_shapes
: 
]
Shape_58Shapecontrol_dependency_32*
out_type0*
_output_shapes
:*
T0
Z
assert_positive_25/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_25/assert_less/LessLessassert_positive_25/ConstShape_58*
T0*
_output_shapes
:
n
$assert_positive_25/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_25/assert_less/AllAll#assert_positive_25/assert_less/Less$assert_positive_25/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_25/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_25/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_25/assert_less/Assert/AssertAssert"assert_positive_25/assert_less/All3assert_positive_25/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_59Shapecontrol_dependency_32*
T0*
_output_shapes
:*
out_type0
Z

unstack_33UnpackShape_59*	
num*
T0*
_output_shapes
: : : *

axis 
S
GreaterEqual_64/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_64GreaterEqual
Maximum_32GreaterEqual_64/y*
T0*
_output_shapes
: 
j
Assert_80/ConstConst*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
r
Assert_80/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_80/AssertAssertGreaterEqual_64Assert_80/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_65/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_65GreaterEqual
Maximum_34GreaterEqual_65/y*
T0*
_output_shapes
: 
k
Assert_81/ConstConst*
dtype0*
_output_shapes
: *,
value#B! Boffset_height must be >= 0.
s
Assert_81/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_81/AssertAssertGreaterEqual_65Assert_81/Assert/data_0*
	summarize*

T
2
N
Greater_16/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_16Greater
Minimum_17Greater_16/y*
T0*
_output_shapes
: 
i
Assert_82/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_82/Assert/data_0Const*
_output_shapes
: *
dtype0**
value!B Btarget_width must be > 0.
\
Assert_82/AssertAssert
Greater_16Assert_82/Assert/data_0*

T
2*
	summarize
N
Greater_17/yConst*
value	B : *
_output_shapes
: *
dtype0
P

Greater_17Greater
Minimum_16Greater_17/y*
T0*
_output_shapes
: 
j
Assert_83/ConstConst*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
r
Assert_83/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
\
Assert_83/AssertAssert
Greater_17Assert_83/Assert/data_0*

T
2*
	summarize
F
add_16Add
Minimum_17
Maximum_32*
_output_shapes
: *
T0
V
GreaterEqual_66GreaterEqualunstack_33:1add_16*
_output_shapes
: *
T0
q
Assert_84/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
y
Assert_84/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_84/AssertAssertGreaterEqual_66Assert_84/Assert/data_0*
	summarize*

T
2
F
add_17Add
Minimum_16
Maximum_34*
T0*
_output_shapes
: 
T
GreaterEqual_67GreaterEqual
unstack_33add_17*
T0*
_output_shapes
: 
r
Assert_85/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_85/Assert/data_0Const*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_85/AssertAssertGreaterEqual_67Assert_85/Assert/data_0*
	summarize*

T
2
Т
control_dependency_33Identitycontrol_dependency_32-^assert_positive_25/assert_less/Assert/Assert^Assert_80/Assert^Assert_81/Assert^Assert_82/Assert^Assert_83/Assert^Assert_84/Assert^Assert_85/Assert*
T0*
_class
loc:@DecodeJpeg_8*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_24/2Const*
_output_shapes
: *
dtype0*
value	B : 
n
stack_24Pack
Maximum_34
Maximum_32
stack_24/2*

axis *
_output_shapes
:*
T0*
N
U

stack_25/2Const*
dtype0*
_output_shapes
: *
valueB :
џџџџџџџџџ
n
stack_25Pack
Minimum_16
Minimum_17
stack_25/2*
T0*

axis *
N*
_output_shapes
:

Slice_8Slicecontrol_dependency_33stack_24stack_25*
Index0*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
O
Shape_60ShapeSlice_8*
out_type0*
_output_shapes
:*
T0
Z
assert_positive_26/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
t
#assert_positive_26/assert_less/LessLessassert_positive_26/ConstShape_60*
_output_shapes
:*
T0
n
$assert_positive_26/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_26/assert_less/AllAll#assert_positive_26/assert_less/Less$assert_positive_26/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_26/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_26/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_26/assert_less/Assert/AssertAssert"assert_positive_26/assert_less/All3assert_positive_26/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_61ShapeSlice_8*
out_type0*
_output_shapes
:*
T0
Z

unstack_34UnpackShape_61*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_58/xConst*
value
B :*
dtype0*
_output_shapes
: 
D
sub_58Subsub_58/x
Maximum_33*
_output_shapes
: *
T0
D
sub_59Subsub_58unstack_34:1*
T0*
_output_shapes
: 
J
sub_60/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_60Subsub_60/x
Maximum_35*
T0*
_output_shapes
: 
B
sub_61Subsub_60
unstack_34*
_output_shapes
: *
T0
S
GreaterEqual_68/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_68GreaterEqual
Maximum_35GreaterEqual_68/y*
_output_shapes
: *
T0
j
Assert_86/ConstConst*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
r
Assert_86/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
a
Assert_86/AssertAssertGreaterEqual_68Assert_86/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_69/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_69GreaterEqual
Maximum_33GreaterEqual_69/y*
_output_shapes
: *
T0
i
Assert_87/ConstConst**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
q
Assert_87/Assert/data_0Const**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
a
Assert_87/AssertAssertGreaterEqual_69Assert_87/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_70/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_70GreaterEqualsub_59GreaterEqual_70/y*
T0*
_output_shapes
: 
p
Assert_88/ConstConst*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_88/Assert/data_0Const*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_88/AssertAssertGreaterEqual_70Assert_88/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_71/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_71GreaterEqualsub_61GreaterEqual_71/y*
T0*
_output_shapes
: 
q
Assert_89/ConstConst*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
y
Assert_89/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!height must be <= target - offset
a
Assert_89/AssertAssertGreaterEqual_71Assert_89/Assert/data_0*
	summarize*

T
2

control_dependency_34IdentitySlice_8-^assert_positive_26/assert_less/Assert/Assert^Assert_86/Assert^Assert_87/Assert^Assert_88/Assert^Assert_89/Assert*
_class
loc:@Slice_8*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_26/4Const*
value	B : *
_output_shapes
: *
dtype0
L

stack_26/5Const*
_output_shapes
: *
dtype0*
value	B : 

stack_26Pack
Maximum_35sub_61
Maximum_33sub_59
stack_26/4
stack_26/5*

axis *
_output_shapes
:*
T0*
N
a
Reshape_16/shapeConst*
dtype0*
_output_shapes
:*
valueB"      
h

Reshape_16Reshapestack_26Reshape_16/shape*
Tshape0*
_output_shapes

:*
T0
w
Pad_8Padcontrol_dependency_34
Reshape_16*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_62ShapePad_8*
_output_shapes
:*
out_type0*
T0
Z

unstack_35UnpackShape_62*	
num*
T0*
_output_shapes
: : : *

axis 
y
control_dependency_35IdentityPad_8*
T0*
_class

loc:@Pad_8*,
_output_shapes
:Pџџџџџџџџџ
e
Reshape_17/shapeConst*
dtype0*
_output_shapes
:*!
valueB"P         
z

Reshape_17Reshapecontrol_dependency_35Reshape_17/shape*
T0*#
_output_shapes
:P*
Tshape0
Z
	ToFloat_8Cast
Reshape_17*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_8/yConst*
valueB
 *  C*
dtype0*
_output_shapes
: 
R
div_8RealDiv	ToFloat_8div_8/y*
T0*#
_output_shapes
:P
M
sub_62/yConst*
valueB
 *   ?*
_output_shapes
: *
dtype0
L
sub_62Subdiv_8sub_62/y*#
_output_shapes
:P*
T0
v
shuffle_batch_8/ConstConst*-
value$B""                      №?*
_output_shapes
:*
dtype0
Y
shuffle_batch_8/Const_1Const*
value	B
 Z*
dtype0
*
_output_shapes
: 
ј
$shuffle_batch_8/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
seed2 *
	container *
shared_name *

seed *
_output_shapes
: *
component_types
2*
capacity*
min_after_dequeue

z
shuffle_batch_8/cond/SwitchSwitchshuffle_batch_8/Const_1shuffle_batch_8/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_8/cond/switch_tIdentityshuffle_batch_8/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_8/cond/switch_fIdentityshuffle_batch_8/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_8/cond/pred_idIdentityshuffle_batch_8/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_8/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_8/random_shuffle_queueshuffle_batch_8/cond/pred_id*
T0*
_output_shapes
: : *7
_class-
+)loc:@shuffle_batch_8/random_shuffle_queue
Т
:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_62shuffle_batch_8/cond/pred_id*
T0*
_class
loc:@sub_62*2
_output_shapes 
:P:P
Ю
:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_8/Constshuffle_batch_8/cond/pred_id* 
_output_shapes
::*(
_class
loc:@shuffle_batch_8/Const*
T0
­
1shuffle_batch_8/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_8/cond/control_dependencyIdentityshuffle_batch_8/cond/switch_t2^shuffle_batch_8/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_8/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_8/cond/NoOpNoOp^shuffle_batch_8/cond/switch_f
У
)shuffle_batch_8/cond/control_dependency_1Identityshuffle_batch_8/cond/switch_f^shuffle_batch_8/cond/NoOp*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_8/cond/switch_f*
T0

Ѓ
shuffle_batch_8/cond/MergeMerge)shuffle_batch_8/cond/control_dependency_1'shuffle_batch_8/cond/control_dependency*
T0
*
N*
_output_shapes
: : 

*shuffle_batch_8/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_8/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_8/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_8/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_8/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_8/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_8/sub/yConst*
_output_shapes
: *
dtype0*
value	B :

}
shuffle_batch_8/subSub)shuffle_batch_8/random_shuffle_queue_Sizeshuffle_batch_8/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_8/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_8/MaximumMaximumshuffle_batch_8/Maximum/xshuffle_batch_8/sub*
_output_shapes
: *
T0
e
shuffle_batch_8/CastCastshuffle_batch_8/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_8/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_8/mulMulshuffle_batch_8/Castshuffle_batch_8/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_8/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_8/fraction_over_10_of_12_full*
_output_shapes
: *
dtype0
Є
+shuffle_batch_8/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_8/fraction_over_10_of_12_full/tagsshuffle_batch_8/mul*
_output_shapes
: *
T0
S
shuffle_batch_8/nConst*
value	B :*
dtype0*
_output_shapes
: 
Ч
shuffle_batch_8QueueDequeueManyV2$shuffle_batch_8/random_shuffle_queueshuffle_batch_8/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
O
concat_4/axisConst*
value	B : *
dtype0*
_output_shapes
: 

concat_4ConcatV2shuffle_batch_6shuffle_batch_7shuffle_batch_8concat_4/axis*

Tidx0*
T0*
N*'
_output_shapes
:P
O
concat_5/axisConst*
dtype0*
_output_shapes
: *
value	B : 

concat_5ConcatV2shuffle_batch_6:1shuffle_batch_7:1shuffle_batch_8:1concat_5/axis*
N*

Tidx0*
T0*
_output_shapes

:
Й
6ConvNet/conv2d/kernel/Initializer/random_uniform/shapeConst*
_output_shapes
:*
dtype0*(
_class
loc:@ConvNet/conv2d/kernel*%
valueB"             
Ѓ
4ConvNet/conv2d/kernel/Initializer/random_uniform/minConst*(
_class
loc:@ConvNet/conv2d/kernel*
valueB
 *О*
_output_shapes
: *
dtype0
Ѓ
4ConvNet/conv2d/kernel/Initializer/random_uniform/maxConst*(
_class
loc:@ConvNet/conv2d/kernel*
valueB
 *>*
dtype0*
_output_shapes
: 

>ConvNet/conv2d/kernel/Initializer/random_uniform/RandomUniformRandomUniform6ConvNet/conv2d/kernel/Initializer/random_uniform/shape*

seed *
seed2 *
dtype0*
T0*&
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel
ђ
4ConvNet/conv2d/kernel/Initializer/random_uniform/subSub4ConvNet/conv2d/kernel/Initializer/random_uniform/max4ConvNet/conv2d/kernel/Initializer/random_uniform/min*
T0*
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel

4ConvNet/conv2d/kernel/Initializer/random_uniform/mulMul>ConvNet/conv2d/kernel/Initializer/random_uniform/RandomUniform4ConvNet/conv2d/kernel/Initializer/random_uniform/sub*
T0*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: 
ў
0ConvNet/conv2d/kernel/Initializer/random_uniformAdd4ConvNet/conv2d/kernel/Initializer/random_uniform/mul4ConvNet/conv2d/kernel/Initializer/random_uniform/min*
T0*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: 
У
ConvNet/conv2d/kernel
VariableV2*
shared_name *(
_class
loc:@ConvNet/conv2d/kernel*
	container *
shape: *
dtype0*&
_output_shapes
: 
ѓ
ConvNet/conv2d/kernel/AssignAssignConvNet/conv2d/kernel0ConvNet/conv2d/kernel/Initializer/random_uniform*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: *
T0*
validate_shape(*
use_locking(

ConvNet/conv2d/kernel/readIdentityConvNet/conv2d/kernel*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: *
T0

%ConvNet/conv2d/bias/Initializer/ConstConst*
dtype0*
_output_shapes
: *&
_class
loc:@ConvNet/conv2d/bias*
valueB *    
Ї
ConvNet/conv2d/bias
VariableV2*
_output_shapes
: *
dtype0*
shape: *
	container *&
_class
loc:@ConvNet/conv2d/bias*
shared_name 
ж
ConvNet/conv2d/bias/AssignAssignConvNet/conv2d/bias%ConvNet/conv2d/bias/Initializer/Const*&
_class
loc:@ConvNet/conv2d/bias*
_output_shapes
: *
T0*
validate_shape(*
use_locking(

ConvNet/conv2d/bias/readIdentityConvNet/conv2d/bias*
T0*&
_class
loc:@ConvNet/conv2d/bias*
_output_shapes
: 
y
 ConvNet/conv2d/convolution/ShapeConst*%
valueB"             *
dtype0*
_output_shapes
:
y
(ConvNet/conv2d/convolution/dilation_rateConst*
dtype0*
_output_shapes
:*
valueB"      
в
ConvNet/conv2d/convolutionConv2DconcatConvNet/conv2d/kernel/read*
T0*
strides
*
data_formatNHWC*
use_cudnn_on_gpu(*
paddingVALID*'
_output_shapes
:N 
 
ConvNet/conv2d/BiasAddBiasAddConvNet/conv2d/convolutionConvNet/conv2d/bias/read*'
_output_shapes
:N *
data_formatNHWC*
T0
e
ConvNet/conv2d/ReluReluConvNet/conv2d/BiasAdd*'
_output_shapes
:N *
T0
С
ConvNet/max_pooling2d/MaxPoolMaxPoolConvNet/conv2d/Relu*
paddingVALID*
T0*
strides
*
data_formatNHWC*&
_output_shapes
:'E *
ksize

Н
8ConvNet/conv2d_1/kernel/Initializer/random_uniform/shapeConst*
dtype0*
_output_shapes
:**
_class 
loc:@ConvNet/conv2d_1/kernel*%
valueB"          @   
Ї
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/minConst**
_class 
loc:@ConvNet/conv2d_1/kernel*
valueB
 *ЋЊЊН*
_output_shapes
: *
dtype0
Ї
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/maxConst**
_class 
loc:@ConvNet/conv2d_1/kernel*
valueB
 *ЋЊЊ=*
_output_shapes
: *
dtype0

@ConvNet/conv2d_1/kernel/Initializer/random_uniform/RandomUniformRandomUniform8ConvNet/conv2d_1/kernel/Initializer/random_uniform/shape*

seed *
seed2 *
dtype0*
T0*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel
њ
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/subSub6ConvNet/conv2d_1/kernel/Initializer/random_uniform/max6ConvNet/conv2d_1/kernel/Initializer/random_uniform/min*
_output_shapes
: **
_class 
loc:@ConvNet/conv2d_1/kernel*
T0

6ConvNet/conv2d_1/kernel/Initializer/random_uniform/mulMul@ConvNet/conv2d_1/kernel/Initializer/random_uniform/RandomUniform6ConvNet/conv2d_1/kernel/Initializer/random_uniform/sub*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel*
T0

2ConvNet/conv2d_1/kernel/Initializer/random_uniformAdd6ConvNet/conv2d_1/kernel/Initializer/random_uniform/mul6ConvNet/conv2d_1/kernel/Initializer/random_uniform/min*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel*
T0
Ч
ConvNet/conv2d_1/kernel
VariableV2*
shared_name *
shape: @*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel*
dtype0*
	container 
ћ
ConvNet/conv2d_1/kernel/AssignAssignConvNet/conv2d_1/kernel2ConvNet/conv2d_1/kernel/Initializer/random_uniform*
use_locking(*
T0**
_class 
loc:@ConvNet/conv2d_1/kernel*
validate_shape(*&
_output_shapes
: @

ConvNet/conv2d_1/kernel/readIdentityConvNet/conv2d_1/kernel*
T0**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @

'ConvNet/conv2d_1/bias/Initializer/ConstConst*
dtype0*
_output_shapes
:@*(
_class
loc:@ConvNet/conv2d_1/bias*
valueB@*    
Ћ
ConvNet/conv2d_1/bias
VariableV2*
shared_name *(
_class
loc:@ConvNet/conv2d_1/bias*
	container *
shape:@*
dtype0*
_output_shapes
:@
о
ConvNet/conv2d_1/bias/AssignAssignConvNet/conv2d_1/bias'ConvNet/conv2d_1/bias/Initializer/Const*
_output_shapes
:@*
validate_shape(*(
_class
loc:@ConvNet/conv2d_1/bias*
T0*
use_locking(

ConvNet/conv2d_1/bias/readIdentityConvNet/conv2d_1/bias*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@*
T0
{
"ConvNet/conv2d_2/convolution/ShapeConst*%
valueB"          @   *
dtype0*
_output_shapes
:
{
*ConvNet/conv2d_2/convolution/dilation_rateConst*
_output_shapes
:*
dtype0*
valueB"      
ь
ConvNet/conv2d_2/convolutionConv2DConvNet/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*
paddingVALID*
T0*
strides
*
data_formatNHWC*&
_output_shapes
:%C@*
use_cudnn_on_gpu(
Ѕ
ConvNet/conv2d_2/BiasAddBiasAddConvNet/conv2d_2/convolutionConvNet/conv2d_1/bias/read*&
_output_shapes
:%C@*
T0*
data_formatNHWC
h
ConvNet/conv2d_2/ReluReluConvNet/conv2d_2/BiasAdd*&
_output_shapes
:%C@*
T0
Х
ConvNet/max_pooling2d_2/MaxPoolMaxPoolConvNet/conv2d_2/Relu*
ksize
*&
_output_shapes
:!@*
strides
*
data_formatNHWC*
T0*
paddingVALID
f
ConvNet/Reshape/shapeConst*
_output_shapes
:*
dtype0*
valueB"     

ConvNet/ReshapeReshapeConvNet/max_pooling2d_2/MaxPoolConvNet/Reshape/shape*
T0*
Tshape0* 
_output_shapes
:
Љ
Џ
5ConvNet/dense/kernel/Initializer/random_uniform/shapeConst*'
_class
loc:@ConvNet/dense/kernel*
valueB"     *
_output_shapes
:*
dtype0
Ё
3ConvNet/dense/kernel/Initializer/random_uniform/minConst*
dtype0*
_output_shapes
: *'
_class
loc:@ConvNet/dense/kernel*
valueB
 *vбMМ
Ё
3ConvNet/dense/kernel/Initializer/random_uniform/maxConst*
dtype0*
_output_shapes
: *'
_class
loc:@ConvNet/dense/kernel*
valueB
 *vбM<
џ
=ConvNet/dense/kernel/Initializer/random_uniform/RandomUniformRandomUniform5ConvNet/dense/kernel/Initializer/random_uniform/shape*

seed *
T0*'
_class
loc:@ConvNet/dense/kernel*
seed2 *
dtype0* 
_output_shapes
:
Љ
ю
3ConvNet/dense/kernel/Initializer/random_uniform/subSub3ConvNet/dense/kernel/Initializer/random_uniform/max3ConvNet/dense/kernel/Initializer/random_uniform/min*
T0*
_output_shapes
: *'
_class
loc:@ConvNet/dense/kernel

3ConvNet/dense/kernel/Initializer/random_uniform/mulMul=ConvNet/dense/kernel/Initializer/random_uniform/RandomUniform3ConvNet/dense/kernel/Initializer/random_uniform/sub* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel*
T0
є
/ConvNet/dense/kernel/Initializer/random_uniformAdd3ConvNet/dense/kernel/Initializer/random_uniform/mul3ConvNet/dense/kernel/Initializer/random_uniform/min*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0
Е
ConvNet/dense/kernel
VariableV2*
shared_name *'
_class
loc:@ConvNet/dense/kernel*
	container *
shape:
Љ*
dtype0* 
_output_shapes
:
Љ
щ
ConvNet/dense/kernel/AssignAssignConvNet/dense/kernel/ConvNet/dense/kernel/Initializer/random_uniform*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0*
validate_shape(*
use_locking(

ConvNet/dense/kernel/readIdentityConvNet/dense/kernel* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel*
T0

$ConvNet/dense/bias/Initializer/ConstConst*%
_class
loc:@ConvNet/dense/bias*
valueB*    *
dtype0*
_output_shapes
:
Ѕ
ConvNet/dense/bias
VariableV2*
_output_shapes
:*
dtype0*
shape:*
	container *%
_class
loc:@ConvNet/dense/bias*
shared_name 
в
ConvNet/dense/bias/AssignAssignConvNet/dense/bias$ConvNet/dense/bias/Initializer/Const*
use_locking(*
T0*%
_class
loc:@ConvNet/dense/bias*
validate_shape(*
_output_shapes
:

ConvNet/dense/bias/readIdentityConvNet/dense/bias*
T0*%
_class
loc:@ConvNet/dense/bias*
_output_shapes
:

ConvNet/dense/MatMulMatMulConvNet/ReshapeConvNet/dense/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet/dense/BiasAddBiasAddConvNet/dense/MatMulConvNet/dense/bias/read*
T0*
data_formatNHWC*
_output_shapes

:
Z
ConvNet/dense/ReluReluConvNet/dense/BiasAdd*
T0*
_output_shapes

:
Г
7ConvNet/dense_1/kernel/Initializer/random_uniform/shapeConst*)
_class
loc:@ConvNet/dense_1/kernel*
valueB"      *
_output_shapes
:*
dtype0
Ѕ
5ConvNet/dense_1/kernel/Initializer/random_uniform/minConst*
dtype0*
_output_shapes
: *)
_class
loc:@ConvNet/dense_1/kernel*
valueB
 *зГ]П
Ѕ
5ConvNet/dense_1/kernel/Initializer/random_uniform/maxConst*
_output_shapes
: *
dtype0*)
_class
loc:@ConvNet/dense_1/kernel*
valueB
 *зГ]?

?ConvNet/dense_1/kernel/Initializer/random_uniform/RandomUniformRandomUniform7ConvNet/dense_1/kernel/Initializer/random_uniform/shape*

seed *
seed2 *
dtype0*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
і
5ConvNet/dense_1/kernel/Initializer/random_uniform/subSub5ConvNet/dense_1/kernel/Initializer/random_uniform/max5ConvNet/dense_1/kernel/Initializer/random_uniform/min*)
_class
loc:@ConvNet/dense_1/kernel*
_output_shapes
: *
T0

5ConvNet/dense_1/kernel/Initializer/random_uniform/mulMul?ConvNet/dense_1/kernel/Initializer/random_uniform/RandomUniform5ConvNet/dense_1/kernel/Initializer/random_uniform/sub*
T0*)
_class
loc:@ConvNet/dense_1/kernel*
_output_shapes

:
њ
1ConvNet/dense_1/kernel/Initializer/random_uniformAdd5ConvNet/dense_1/kernel/Initializer/random_uniform/mul5ConvNet/dense_1/kernel/Initializer/random_uniform/min*
T0*)
_class
loc:@ConvNet/dense_1/kernel*
_output_shapes

:
Е
ConvNet/dense_1/kernel
VariableV2*
	container *
shared_name *
dtype0*
shape
:*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
я
ConvNet/dense_1/kernel/AssignAssignConvNet/dense_1/kernel1ConvNet/dense_1/kernel/Initializer/random_uniform*
use_locking(*
validate_shape(*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel

ConvNet/dense_1/kernel/readIdentityConvNet/dense_1/kernel*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel*
T0

&ConvNet/dense_1/bias/Initializer/ConstConst*
_output_shapes
:*
dtype0*'
_class
loc:@ConvNet/dense_1/bias*
valueB*    
Љ
ConvNet/dense_1/bias
VariableV2*
shape:*
_output_shapes
:*
shared_name *'
_class
loc:@ConvNet/dense_1/bias*
dtype0*
	container 
к
ConvNet/dense_1/bias/AssignAssignConvNet/dense_1/bias&ConvNet/dense_1/bias/Initializer/Const*'
_class
loc:@ConvNet/dense_1/bias*
_output_shapes
:*
T0*
validate_shape(*
use_locking(

ConvNet/dense_1/bias/readIdentityConvNet/dense_1/bias*
_output_shapes
:*'
_class
loc:@ConvNet/dense_1/bias*
T0
 
ConvNet/dense_2/MatMulMatMulConvNet/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet/dense_2/BiasAddBiasAddConvNet/dense_2/MatMulConvNet/dense_1/bias/read*
_output_shapes

:*
data_formatNHWC*
T0
d
ConvNet/dense_2/SoftmaxSoftmaxConvNet/dense_2/BiasAdd*
_output_shapes

:*
T0
{
"ConvNet_1/conv2d/convolution/ShapeConst*
_output_shapes
:*
dtype0*%
valueB"             
{
*ConvNet_1/conv2d/convolution/dilation_rateConst*
valueB"      *
dtype0*
_output_shapes
:
ж
ConvNet_1/conv2d/convolutionConv2Dconcat_2ConvNet/conv2d/kernel/read*
use_cudnn_on_gpu(*
T0*
paddingVALID*'
_output_shapes
:N *
data_formatNHWC*
strides

Є
ConvNet_1/conv2d/BiasAddBiasAddConvNet_1/conv2d/convolutionConvNet/conv2d/bias/read*
T0*
data_formatNHWC*'
_output_shapes
:N 
i
ConvNet_1/conv2d/ReluReluConvNet_1/conv2d/BiasAdd*'
_output_shapes
:N *
T0
Х
ConvNet_1/max_pooling2d/MaxPoolMaxPoolConvNet_1/conv2d/Relu*
ksize
*&
_output_shapes
:'E *
T0*
data_formatNHWC*
strides
*
paddingVALID
}
$ConvNet_1/conv2d_2/convolution/ShapeConst*%
valueB"          @   *
dtype0*
_output_shapes
:
}
,ConvNet_1/conv2d_2/convolution/dilation_rateConst*
valueB"      *
dtype0*
_output_shapes
:
№
ConvNet_1/conv2d_2/convolutionConv2DConvNet_1/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*
use_cudnn_on_gpu(*
T0*
paddingVALID*&
_output_shapes
:%C@*
data_formatNHWC*
strides

Љ
ConvNet_1/conv2d_2/BiasAddBiasAddConvNet_1/conv2d_2/convolutionConvNet/conv2d_1/bias/read*
data_formatNHWC*
T0*&
_output_shapes
:%C@
l
ConvNet_1/conv2d_2/ReluReluConvNet_1/conv2d_2/BiasAdd*&
_output_shapes
:%C@*
T0
Щ
!ConvNet_1/max_pooling2d_2/MaxPoolMaxPoolConvNet_1/conv2d_2/Relu*
paddingVALID*
T0*
data_formatNHWC*
strides
*&
_output_shapes
:!@*
ksize

h
ConvNet_1/Reshape/shapeConst*
dtype0*
_output_shapes
:*
valueB"     

ConvNet_1/ReshapeReshape!ConvNet_1/max_pooling2d_2/MaxPoolConvNet_1/Reshape/shape*
T0* 
_output_shapes
:
Љ*
Tshape0

ConvNet_1/dense/MatMulMatMulConvNet_1/ReshapeConvNet/dense/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_1/dense/BiasAddBiasAddConvNet_1/dense/MatMulConvNet/dense/bias/read*
_output_shapes

:*
data_formatNHWC*
T0
^
ConvNet_1/dense/ReluReluConvNet_1/dense/BiasAdd*
T0*
_output_shapes

:
Є
ConvNet_1/dense_2/MatMulMatMulConvNet_1/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_1/dense_2/BiasAddBiasAddConvNet_1/dense_2/MatMulConvNet/dense_1/bias/read*
_output_shapes

:*
T0*
data_formatNHWC
h
ConvNet_1/dense_2/SoftmaxSoftmaxConvNet_1/dense_2/BiasAdd*
T0*
_output_shapes

:
{
"ConvNet_2/conv2d/convolution/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"             
{
*ConvNet_2/conv2d/convolution/dilation_rateConst*
valueB"      *
dtype0*
_output_shapes
:
ж
ConvNet_2/conv2d/convolutionConv2Dconcat_4ConvNet/conv2d/kernel/read*
use_cudnn_on_gpu(*'
_output_shapes
:N *
data_formatNHWC*
strides
*
T0*
paddingVALID
Є
ConvNet_2/conv2d/BiasAddBiasAddConvNet_2/conv2d/convolutionConvNet/conv2d/bias/read*
data_formatNHWC*
T0*'
_output_shapes
:N 
i
ConvNet_2/conv2d/ReluReluConvNet_2/conv2d/BiasAdd*'
_output_shapes
:N *
T0
Х
ConvNet_2/max_pooling2d/MaxPoolMaxPoolConvNet_2/conv2d/Relu*
ksize
*&
_output_shapes
:'E *
data_formatNHWC*
strides
*
T0*
paddingVALID
}
$ConvNet_2/conv2d_2/convolution/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"          @   
}
,ConvNet_2/conv2d_2/convolution/dilation_rateConst*
_output_shapes
:*
dtype0*
valueB"      
№
ConvNet_2/conv2d_2/convolutionConv2DConvNet_2/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*
data_formatNHWC*
strides
*&
_output_shapes
:%C@*
paddingVALID*
T0*
use_cudnn_on_gpu(
Љ
ConvNet_2/conv2d_2/BiasAddBiasAddConvNet_2/conv2d_2/convolutionConvNet/conv2d_1/bias/read*&
_output_shapes
:%C@*
T0*
data_formatNHWC
l
ConvNet_2/conv2d_2/ReluReluConvNet_2/conv2d_2/BiasAdd*
T0*&
_output_shapes
:%C@
Щ
!ConvNet_2/max_pooling2d_2/MaxPoolMaxPoolConvNet_2/conv2d_2/Relu*
ksize
*&
_output_shapes
:!@*
T0*
data_formatNHWC*
strides
*
paddingVALID
h
ConvNet_2/Reshape/shapeConst*
_output_shapes
:*
dtype0*
valueB"     

ConvNet_2/ReshapeReshape!ConvNet_2/max_pooling2d_2/MaxPoolConvNet_2/Reshape/shape* 
_output_shapes
:
Љ*
Tshape0*
T0

ConvNet_2/dense/MatMulMatMulConvNet_2/ReshapeConvNet/dense/kernel/read*
transpose_b( *
T0*
_output_shapes

:*
transpose_a( 

ConvNet_2/dense/BiasAddBiasAddConvNet_2/dense/MatMulConvNet/dense/bias/read*
_output_shapes

:*
data_formatNHWC*
T0
^
ConvNet_2/dense/ReluReluConvNet_2/dense/BiasAdd*
_output_shapes

:*
T0
Є
ConvNet_2/dense_2/MatMulMatMulConvNet_2/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_2/dense_2/BiasAddBiasAddConvNet_2/dense_2/MatMulConvNet/dense_1/bias/read*
T0*
data_formatNHWC*
_output_shapes

:
h
ConvNet_2/dense_2/SoftmaxSoftmaxConvNet_2/dense_2/BiasAdd*
_output_shapes

:*
T0
]
CastCastConvNet/dense_2/Softmax*

SrcT0*
_output_shapes

:*

DstT0
F
sub_63SubCastconcat_1*
T0*
_output_shapes

:
A
SquareSquaresub_63*
T0*
_output_shapes

:
V
ConstConst*
dtype0*
_output_shapes
:*
valueB"       
W
SumSumSquareConst*
_output_shapes
: *
T0*
	keep_dims( *

Tidx0
a
Cast_1CastConvNet_1/dense_2/Softmax*

SrcT0*
_output_shapes

:*

DstT0
H
sub_64SubCast_1concat_3*
T0*
_output_shapes

:
C
Square_1Squaresub_64*
_output_shapes

:*
T0
X
Const_1Const*
valueB"       *
_output_shapes
:*
dtype0
]
Sum_1SumSquare_1Const_1*
_output_shapes
: *
T0*
	keep_dims( *

Tidx0
a
Cast_2CastConvNet_2/dense_2/Softmax*
_output_shapes

:*

DstT0*

SrcT0
H
sub_65SubCast_2concat_5*
_output_shapes

:*
T0
C
Square_2Squaresub_65*
_output_shapes

:*
T0
X
Const_2Const*
valueB"       *
_output_shapes
:*
dtype0
]
Sum_2SumSquare_2Const_2*
_output_shapes
: *
T0*
	keep_dims( *

Tidx0
R
gradients/ShapeConst*
valueB *
dtype0*
_output_shapes
: 
X
gradients/ConstConst*
valueB 2      №?*
dtype0*
_output_shapes
: 
Y
gradients/FillFillgradients/Shapegradients/Const*
_output_shapes
: *
T0
q
 gradients/Sum_grad/Reshape/shapeConst*
valueB"      *
_output_shapes
:*
dtype0

gradients/Sum_grad/ReshapeReshapegradients/Fill gradients/Sum_grad/Reshape/shape*
Tshape0*
_output_shapes

:*
T0
r
!gradients/Sum_grad/Tile/multiplesConst*
valueB"      *
dtype0*
_output_shapes
:

gradients/Sum_grad/TileTilegradients/Sum_grad/Reshape!gradients/Sum_grad/Tile/multiples*
_output_shapes

:*
T0*

Tmultiples0
~
gradients/Square_grad/mul/xConst^gradients/Sum_grad/Tile*
valueB 2       @*
_output_shapes
: *
dtype0
n
gradients/Square_grad/mulMulgradients/Square_grad/mul/xsub_63*
T0*
_output_shapes

:

gradients/Square_grad/mul_1Mulgradients/Sum_grad/Tilegradients/Square_grad/mul*
T0*
_output_shapes

:
l
gradients/sub_63_grad/ShapeConst*
valueB"      *
_output_shapes
:*
dtype0
n
gradients/sub_63_grad/Shape_1Const*
valueB"      *
_output_shapes
:*
dtype0
Н
+gradients/sub_63_grad/BroadcastGradientArgsBroadcastGradientArgsgradients/sub_63_grad/Shapegradients/sub_63_grad/Shape_1*
T0*2
_output_shapes 
:џџџџџџџџџ:џџџџџџџџџ
Њ
gradients/sub_63_grad/SumSumgradients/Square_grad/mul_1+gradients/sub_63_grad/BroadcastGradientArgs*
_output_shapes
:*
T0*
	keep_dims( *

Tidx0

gradients/sub_63_grad/ReshapeReshapegradients/sub_63_grad/Sumgradients/sub_63_grad/Shape*
T0*
_output_shapes

:*
Tshape0
Ў
gradients/sub_63_grad/Sum_1Sumgradients/Square_grad/mul_1-gradients/sub_63_grad/BroadcastGradientArgs:1*
_output_shapes
:*
T0*
	keep_dims( *

Tidx0
`
gradients/sub_63_grad/NegNeggradients/sub_63_grad/Sum_1*
_output_shapes
:*
T0

gradients/sub_63_grad/Reshape_1Reshapegradients/sub_63_grad/Neggradients/sub_63_grad/Shape_1*
T0*
_output_shapes

:*
Tshape0
p
&gradients/sub_63_grad/tuple/group_depsNoOp^gradients/sub_63_grad/Reshape ^gradients/sub_63_grad/Reshape_1
н
.gradients/sub_63_grad/tuple/control_dependencyIdentitygradients/sub_63_grad/Reshape'^gradients/sub_63_grad/tuple/group_deps*
_output_shapes

:*0
_class&
$"loc:@gradients/sub_63_grad/Reshape*
T0
у
0gradients/sub_63_grad/tuple/control_dependency_1Identitygradients/sub_63_grad/Reshape_1'^gradients/sub_63_grad/tuple/group_deps*
_output_shapes

:*2
_class(
&$loc:@gradients/sub_63_grad/Reshape_1*
T0

gradients/Cast_grad/CastCast.gradients/sub_63_grad/tuple/control_dependency*
_output_shapes

:*

DstT0*

SrcT0

*gradients/ConvNet/dense_2/Softmax_grad/mulMulgradients/Cast_grad/CastConvNet/dense_2/Softmax*
T0*
_output_shapes

:

<gradients/ConvNet/dense_2/Softmax_grad/Sum/reduction_indicesConst*
_output_shapes
:*
dtype0*
valueB:
н
*gradients/ConvNet/dense_2/Softmax_grad/SumSum*gradients/ConvNet/dense_2/Softmax_grad/mul<gradients/ConvNet/dense_2/Softmax_grad/Sum/reduction_indices*
	keep_dims( *

Tidx0*
T0*
_output_shapes
:

4gradients/ConvNet/dense_2/Softmax_grad/Reshape/shapeConst*
_output_shapes
:*
dtype0*
valueB"џџџџ   
в
.gradients/ConvNet/dense_2/Softmax_grad/ReshapeReshape*gradients/ConvNet/dense_2/Softmax_grad/Sum4gradients/ConvNet/dense_2/Softmax_grad/Reshape/shape*
Tshape0*
_output_shapes

:*
T0
Є
*gradients/ConvNet/dense_2/Softmax_grad/subSubgradients/Cast_grad/Cast.gradients/ConvNet/dense_2/Softmax_grad/Reshape*
_output_shapes

:*
T0
Ё
,gradients/ConvNet/dense_2/Softmax_grad/mul_1Mul*gradients/ConvNet/dense_2/Softmax_grad/subConvNet/dense_2/Softmax*
T0*
_output_shapes

:
Ћ
2gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGradBiasAddGrad,gradients/ConvNet/dense_2/Softmax_grad/mul_1*
data_formatNHWC*
T0*
_output_shapes
:
Ѓ
7gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_depsNoOp-^gradients/ConvNet/dense_2/Softmax_grad/mul_13^gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad

?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependencyIdentity,gradients/ConvNet/dense_2/Softmax_grad/mul_18^gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_deps*?
_class5
31loc:@gradients/ConvNet/dense_2/Softmax_grad/mul_1*
_output_shapes

:*
T0
Ї
Agradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency_1Identity2gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad8^gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_deps*
T0*
_output_shapes
:*E
_class;
97loc:@gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad
у
,gradients/ConvNet/dense_2/MatMul_grad/MatMulMatMul?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependencyConvNet/dense_1/kernel/read*
transpose_b(*
_output_shapes

:*
transpose_a( *
T0
м
.gradients/ConvNet/dense_2/MatMul_grad/MatMul_1MatMulConvNet/dense/Relu?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency*
transpose_b( *
_output_shapes

:*
transpose_a(*
T0

6gradients/ConvNet/dense_2/MatMul_grad/tuple/group_depsNoOp-^gradients/ConvNet/dense_2/MatMul_grad/MatMul/^gradients/ConvNet/dense_2/MatMul_grad/MatMul_1

>gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependencyIdentity,gradients/ConvNet/dense_2/MatMul_grad/MatMul7^gradients/ConvNet/dense_2/MatMul_grad/tuple/group_deps*
_output_shapes

:*?
_class5
31loc:@gradients/ConvNet/dense_2/MatMul_grad/MatMul*
T0
Ё
@gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependency_1Identity.gradients/ConvNet/dense_2/MatMul_grad/MatMul_17^gradients/ConvNet/dense_2/MatMul_grad/tuple/group_deps*
T0*
_output_shapes

:*A
_class7
53loc:@gradients/ConvNet/dense_2/MatMul_grad/MatMul_1
Г
*gradients/ConvNet/dense/Relu_grad/ReluGradReluGrad>gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependencyConvNet/dense/Relu*
T0*
_output_shapes

:
Ї
0gradients/ConvNet/dense/BiasAdd_grad/BiasAddGradBiasAddGrad*gradients/ConvNet/dense/Relu_grad/ReluGrad*
T0*
data_formatNHWC*
_output_shapes
:

5gradients/ConvNet/dense/BiasAdd_grad/tuple/group_depsNoOp+^gradients/ConvNet/dense/Relu_grad/ReluGrad1^gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad

=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependencyIdentity*gradients/ConvNet/dense/Relu_grad/ReluGrad6^gradients/ConvNet/dense/BiasAdd_grad/tuple/group_deps*
T0*
_output_shapes

:*=
_class3
1/loc:@gradients/ConvNet/dense/Relu_grad/ReluGrad

?gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency_1Identity0gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad6^gradients/ConvNet/dense/BiasAdd_grad/tuple/group_deps*
T0*
_output_shapes
:*C
_class9
75loc:@gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad
п
*gradients/ConvNet/dense/MatMul_grad/MatMulMatMul=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependencyConvNet/dense/kernel/read*
transpose_b(* 
_output_shapes
:
Љ*
transpose_a( *
T0
з
,gradients/ConvNet/dense/MatMul_grad/MatMul_1MatMulConvNet/Reshape=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency*
transpose_b( * 
_output_shapes
:
Љ*
transpose_a(*
T0

4gradients/ConvNet/dense/MatMul_grad/tuple/group_depsNoOp+^gradients/ConvNet/dense/MatMul_grad/MatMul-^gradients/ConvNet/dense/MatMul_grad/MatMul_1

<gradients/ConvNet/dense/MatMul_grad/tuple/control_dependencyIdentity*gradients/ConvNet/dense/MatMul_grad/MatMul5^gradients/ConvNet/dense/MatMul_grad/tuple/group_deps* 
_output_shapes
:
Љ*=
_class3
1/loc:@gradients/ConvNet/dense/MatMul_grad/MatMul*
T0

>gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency_1Identity,gradients/ConvNet/dense/MatMul_grad/MatMul_15^gradients/ConvNet/dense/MatMul_grad/tuple/group_deps* 
_output_shapes
:
Љ*?
_class5
31loc:@gradients/ConvNet/dense/MatMul_grad/MatMul_1*
T0
}
$gradients/ConvNet/Reshape_grad/ShapeConst*%
valueB"      !   @   *
_output_shapes
:*
dtype0
д
&gradients/ConvNet/Reshape_grad/ReshapeReshape<gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency$gradients/ConvNet/Reshape_grad/Shape*
T0*&
_output_shapes
:!@*
Tshape0
­
:gradients/ConvNet/max_pooling2d_2/MaxPool_grad/MaxPoolGradMaxPoolGradConvNet/conv2d_2/ReluConvNet/max_pooling2d_2/MaxPool&gradients/ConvNet/Reshape_grad/Reshape*
ksize
*&
_output_shapes
:%C@*
data_formatNHWC*
strides
*
T0*
paddingVALID
Н
-gradients/ConvNet/conv2d_2/Relu_grad/ReluGradReluGrad:gradients/ConvNet/max_pooling2d_2/MaxPool_grad/MaxPoolGradConvNet/conv2d_2/Relu*&
_output_shapes
:%C@*
T0
­
3gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGradBiasAddGrad-gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad*
_output_shapes
:@*
data_formatNHWC*
T0
І
8gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_depsNoOp.^gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad4^gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad
Љ
@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependencyIdentity-gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad9^gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_deps*&
_output_shapes
:%C@*@
_class6
42loc:@gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad*
T0
Ћ
Bgradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency_1Identity3gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad9^gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_deps*
T0*F
_class<
:8loc:@gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad*
_output_shapes
:@

1gradients/ConvNet/conv2d_2/convolution_grad/ShapeConst*%
valueB"   '   E       *
_output_shapes
:*
dtype0
ђ
?gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInputConv2DBackpropInput1gradients/ConvNet/conv2d_2/convolution_grad/ShapeConvNet/conv2d_1/kernel/read@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency*
use_cudnn_on_gpu(*&
_output_shapes
:'E *
data_formatNHWC*
strides
*
T0*
paddingVALID

3gradients/ConvNet/conv2d_2/convolution_grad/Shape_1Const*%
valueB"          @   *
_output_shapes
:*
dtype0
ї
@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilterConv2DBackpropFilterConvNet/max_pooling2d/MaxPool3gradients/ConvNet/conv2d_2/convolution_grad/Shape_1@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency*
use_cudnn_on_gpu(*
T0*
paddingVALID*&
_output_shapes
: @*
data_formatNHWC*
strides

Щ
<gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_depsNoOp@^gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInputA^gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter
е
Dgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependencyIdentity?gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInput=^gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_deps*
T0*&
_output_shapes
:'E *R
_classH
FDloc:@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInput
й
Fgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency_1Identity@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter=^gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_deps*
T0*S
_classI
GEloc:@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter*&
_output_shapes
: @
Ц
8gradients/ConvNet/max_pooling2d/MaxPool_grad/MaxPoolGradMaxPoolGradConvNet/conv2d/ReluConvNet/max_pooling2d/MaxPoolDgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency*
data_formatNHWC*
strides
*'
_output_shapes
:N *
paddingVALID*
T0*
ksize

И
+gradients/ConvNet/conv2d/Relu_grad/ReluGradReluGrad8gradients/ConvNet/max_pooling2d/MaxPool_grad/MaxPoolGradConvNet/conv2d/Relu*
T0*'
_output_shapes
:N 
Љ
1gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGradBiasAddGrad+gradients/ConvNet/conv2d/Relu_grad/ReluGrad*
data_formatNHWC*
T0*
_output_shapes
: 
 
6gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_depsNoOp,^gradients/ConvNet/conv2d/Relu_grad/ReluGrad2^gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad
Ђ
>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependencyIdentity+gradients/ConvNet/conv2d/Relu_grad/ReluGrad7^gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_deps*>
_class4
20loc:@gradients/ConvNet/conv2d/Relu_grad/ReluGrad*'
_output_shapes
:N *
T0
Ѓ
@gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency_1Identity1gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad7^gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_deps*
_output_shapes
: *D
_class:
86loc:@gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad*
T0

/gradients/ConvNet/conv2d/convolution_grad/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"   P         
ы
=gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInputConv2DBackpropInput/gradients/ConvNet/conv2d/convolution_grad/ShapeConvNet/conv2d/kernel/read>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency*'
_output_shapes
:P*
paddingVALID*
use_cudnn_on_gpu(*
data_formatNHWC*
strides
*
T0

1gradients/ConvNet/conv2d/convolution_grad/Shape_1Const*%
valueB"             *
dtype0*
_output_shapes
:
к
>gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilterConv2DBackpropFilterconcat1gradients/ConvNet/conv2d/convolution_grad/Shape_1>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency*
paddingVALID*
data_formatNHWC*
strides
*
use_cudnn_on_gpu(*
T0*&
_output_shapes
: 
У
:gradients/ConvNet/conv2d/convolution_grad/tuple/group_depsNoOp>^gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput?^gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter
Ю
Bgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependencyIdentity=gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput;^gradients/ConvNet/conv2d/convolution_grad/tuple/group_deps*'
_output_shapes
:P*P
_classF
DBloc:@gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput*
T0
б
Dgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependency_1Identity>gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter;^gradients/ConvNet/conv2d/convolution_grad/tuple/group_deps*
T0*Q
_classG
ECloc:@gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter*&
_output_shapes
: 
b
GradientDescent/learning_rateConst*
dtype0*
_output_shapes
: *
valueB
 *
з#<
У
AGradientDescent/update_ConvNet/conv2d/kernel/ApplyGradientDescentApplyGradientDescentConvNet/conv2d/kernelGradientDescent/learning_rateDgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependency_1*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: *
T0*
use_locking( 
­
?GradientDescent/update_ConvNet/conv2d/bias/ApplyGradientDescentApplyGradientDescentConvNet/conv2d/biasGradientDescent/learning_rate@gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency_1*
_output_shapes
: *&
_class
loc:@ConvNet/conv2d/bias*
T0*
use_locking( 
Ы
CGradientDescent/update_ConvNet/conv2d_1/kernel/ApplyGradientDescentApplyGradientDescentConvNet/conv2d_1/kernelGradientDescent/learning_rateFgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency_1*
use_locking( *
T0**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @
Е
AGradientDescent/update_ConvNet/conv2d_1/bias/ApplyGradientDescentApplyGradientDescentConvNet/conv2d_1/biasGradientDescent/learning_rateBgradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency_1*
use_locking( *
T0*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@
Д
@GradientDescent/update_ConvNet/dense/kernel/ApplyGradientDescentApplyGradientDescentConvNet/dense/kernelGradientDescent/learning_rate>gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency_1*
use_locking( *
T0* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel
Љ
>GradientDescent/update_ConvNet/dense/bias/ApplyGradientDescentApplyGradientDescentConvNet/dense/biasGradientDescent/learning_rate?gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency_1*
use_locking( *
T0*
_output_shapes
:*%
_class
loc:@ConvNet/dense/bias
К
BGradientDescent/update_ConvNet/dense_1/kernel/ApplyGradientDescentApplyGradientDescentConvNet/dense_1/kernelGradientDescent/learning_rate@gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependency_1*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel*
T0*
use_locking( 
Б
@GradientDescent/update_ConvNet/dense_1/bias/ApplyGradientDescentApplyGradientDescentConvNet/dense_1/biasGradientDescent/learning_rateAgradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency_1*'
_class
loc:@ConvNet/dense_1/bias*
_output_shapes
:*
T0*
use_locking( 
Г
GradientDescentNoOpB^GradientDescent/update_ConvNet/conv2d/kernel/ApplyGradientDescent@^GradientDescent/update_ConvNet/conv2d/bias/ApplyGradientDescentD^GradientDescent/update_ConvNet/conv2d_1/kernel/ApplyGradientDescentB^GradientDescent/update_ConvNet/conv2d_1/bias/ApplyGradientDescentA^GradientDescent/update_ConvNet/dense/kernel/ApplyGradientDescent?^GradientDescent/update_ConvNet/dense/bias/ApplyGradientDescentC^GradientDescent/update_ConvNet/dense_1/kernel/ApplyGradientDescentA^GradientDescent/update_ConvNet/dense_1/bias/ApplyGradientDescent
P

save/ConstConst*
_output_shapes
: *
dtype0*
valueB Bmodel
к
save/SaveV2/tensor_namesConst*
valueBBConvNet/conv2d/biasBConvNet/conv2d/kernelBConvNet/conv2d_1/biasBConvNet/conv2d_1/kernelBConvNet/dense/biasBConvNet/dense/kernelBConvNet/dense_1/biasBConvNet/dense_1/kernelBmatching_filenamesBmatching_filenames_1Bmatching_filenames_2Bmatching_filenames_3Bmatching_filenames_4Bmatching_filenames_5Bmatching_filenames_6Bmatching_filenames_7Bmatching_filenames_8*
_output_shapes
:*
dtype0

save/SaveV2/shape_and_slicesConst*5
value,B*B B B B B B B B B B B B B B B B B *
dtype0*
_output_shapes
:
ђ
save/SaveV2SaveV2
save/Constsave/SaveV2/tensor_namessave/SaveV2/shape_and_slicesConvNet/conv2d/biasConvNet/conv2d/kernelConvNet/conv2d_1/biasConvNet/conv2d_1/kernelConvNet/dense/biasConvNet/dense/kernelConvNet/dense_1/biasConvNet/dense_1/kernelmatching_filenamesmatching_filenames_1matching_filenames_2matching_filenames_3matching_filenames_4matching_filenames_5matching_filenames_6matching_filenames_7matching_filenames_8*
dtypes
2
}
save/control_dependencyIdentity
save/Const^save/SaveV2*
_class
loc:@save/Const*
_output_shapes
: *
T0
w
save/RestoreV2/tensor_namesConst*(
valueBBConvNet/conv2d/bias*
_output_shapes
:*
dtype0
h
save/RestoreV2/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2	RestoreV2
save/Constsave/RestoreV2/tensor_namessave/RestoreV2/shape_and_slices*
dtypes
2*
_output_shapes
:
А
save/AssignAssignConvNet/conv2d/biassave/RestoreV2*
use_locking(*
validate_shape(*
T0*
_output_shapes
: *&
_class
loc:@ConvNet/conv2d/bias
{
save/RestoreV2_1/tensor_namesConst**
value!BBConvNet/conv2d/kernel*
_output_shapes
:*
dtype0
j
!save/RestoreV2_1/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_1	RestoreV2
save/Constsave/RestoreV2_1/tensor_names!save/RestoreV2_1/shape_and_slices*
dtypes
2*
_output_shapes
:
Ф
save/Assign_1AssignConvNet/conv2d/kernelsave/RestoreV2_1*
use_locking(*
validate_shape(*
T0*&
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel
{
save/RestoreV2_2/tensor_namesConst*
dtype0*
_output_shapes
:**
value!BBConvNet/conv2d_1/bias
j
!save/RestoreV2_2/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_2	RestoreV2
save/Constsave/RestoreV2_2/tensor_names!save/RestoreV2_2/shape_and_slices*
_output_shapes
:*
dtypes
2
И
save/Assign_2AssignConvNet/conv2d_1/biassave/RestoreV2_2*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@*
T0*
validate_shape(*
use_locking(
}
save/RestoreV2_3/tensor_namesConst*
dtype0*
_output_shapes
:*,
value#B!BConvNet/conv2d_1/kernel
j
!save/RestoreV2_3/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_3	RestoreV2
save/Constsave/RestoreV2_3/tensor_names!save/RestoreV2_3/shape_and_slices*
dtypes
2*
_output_shapes
:
Ш
save/Assign_3AssignConvNet/conv2d_1/kernelsave/RestoreV2_3*&
_output_shapes
: @*
validate_shape(**
_class 
loc:@ConvNet/conv2d_1/kernel*
T0*
use_locking(
x
save/RestoreV2_4/tensor_namesConst*
dtype0*
_output_shapes
:*'
valueBBConvNet/dense/bias
j
!save/RestoreV2_4/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_4	RestoreV2
save/Constsave/RestoreV2_4/tensor_names!save/RestoreV2_4/shape_and_slices*
dtypes
2*
_output_shapes
:
В
save/Assign_4AssignConvNet/dense/biassave/RestoreV2_4*
use_locking(*
T0*%
_class
loc:@ConvNet/dense/bias*
validate_shape(*
_output_shapes
:
z
save/RestoreV2_5/tensor_namesConst*)
value BBConvNet/dense/kernel*
dtype0*
_output_shapes
:
j
!save/RestoreV2_5/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_5	RestoreV2
save/Constsave/RestoreV2_5/tensor_names!save/RestoreV2_5/shape_and_slices*
dtypes
2*
_output_shapes
:
М
save/Assign_5AssignConvNet/dense/kernelsave/RestoreV2_5*
use_locking(*
T0*'
_class
loc:@ConvNet/dense/kernel*
validate_shape(* 
_output_shapes
:
Љ
z
save/RestoreV2_6/tensor_namesConst*
dtype0*
_output_shapes
:*)
value BBConvNet/dense_1/bias
j
!save/RestoreV2_6/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_6	RestoreV2
save/Constsave/RestoreV2_6/tensor_names!save/RestoreV2_6/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_6AssignConvNet/dense_1/biassave/RestoreV2_6*
use_locking(*
validate_shape(*
T0*
_output_shapes
:*'
_class
loc:@ConvNet/dense_1/bias
|
save/RestoreV2_7/tensor_namesConst*+
value"B BConvNet/dense_1/kernel*
_output_shapes
:*
dtype0
j
!save/RestoreV2_7/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_7	RestoreV2
save/Constsave/RestoreV2_7/tensor_names!save/RestoreV2_7/shape_and_slices*
dtypes
2*
_output_shapes
:
О
save/Assign_7AssignConvNet/dense_1/kernelsave/RestoreV2_7*
use_locking(*
validate_shape(*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
x
save/RestoreV2_8/tensor_namesConst*'
valueBBmatching_filenames*
_output_shapes
:*
dtype0
j
!save/RestoreV2_8/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_8	RestoreV2
save/Constsave/RestoreV2_8/tensor_names!save/RestoreV2_8/shape_and_slices*
_output_shapes
:*
dtypes
2
А
save/Assign_8Assignmatching_filenamessave/RestoreV2_8*
use_locking(*
T0*%
_class
loc:@matching_filenames*
validate_shape( *
_output_shapes
:
z
save/RestoreV2_9/tensor_namesConst*)
value BBmatching_filenames_1*
_output_shapes
:*
dtype0
j
!save/RestoreV2_9/shape_and_slicesConst*
valueB
B *
_output_shapes
:*
dtype0

save/RestoreV2_9	RestoreV2
save/Constsave/RestoreV2_9/tensor_names!save/RestoreV2_9/shape_and_slices*
dtypes
2*
_output_shapes
:
Д
save/Assign_9Assignmatching_filenames_1save/RestoreV2_9*
use_locking(*
validate_shape( *
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_1
{
save/RestoreV2_10/tensor_namesConst*
_output_shapes
:*
dtype0*)
value BBmatching_filenames_2
k
"save/RestoreV2_10/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_10	RestoreV2
save/Constsave/RestoreV2_10/tensor_names"save/RestoreV2_10/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_10Assignmatching_filenames_2save/RestoreV2_10*
_output_shapes
:*
validate_shape( *'
_class
loc:@matching_filenames_2*
T0*
use_locking(
{
save/RestoreV2_11/tensor_namesConst*
_output_shapes
:*
dtype0*)
value BBmatching_filenames_3
k
"save/RestoreV2_11/shape_and_slicesConst*
valueB
B *
_output_shapes
:*
dtype0

save/RestoreV2_11	RestoreV2
save/Constsave/RestoreV2_11/tensor_names"save/RestoreV2_11/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_11Assignmatching_filenames_3save/RestoreV2_11*
use_locking(*
T0*'
_class
loc:@matching_filenames_3*
validate_shape( *
_output_shapes
:
{
save/RestoreV2_12/tensor_namesConst*)
value BBmatching_filenames_4*
_output_shapes
:*
dtype0
k
"save/RestoreV2_12/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_12	RestoreV2
save/Constsave/RestoreV2_12/tensor_names"save/RestoreV2_12/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_12Assignmatching_filenames_4save/RestoreV2_12*
use_locking(*
validate_shape( *
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_4
{
save/RestoreV2_13/tensor_namesConst*
_output_shapes
:*
dtype0*)
value BBmatching_filenames_5
k
"save/RestoreV2_13/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_13	RestoreV2
save/Constsave/RestoreV2_13/tensor_names"save/RestoreV2_13/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_13Assignmatching_filenames_5save/RestoreV2_13*
use_locking(*
T0*'
_class
loc:@matching_filenames_5*
validate_shape( *
_output_shapes
:
{
save/RestoreV2_14/tensor_namesConst*)
value BBmatching_filenames_6*
_output_shapes
:*
dtype0
k
"save/RestoreV2_14/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_14	RestoreV2
save/Constsave/RestoreV2_14/tensor_names"save/RestoreV2_14/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_14Assignmatching_filenames_6save/RestoreV2_14*'
_class
loc:@matching_filenames_6*
_output_shapes
:*
T0*
validate_shape( *
use_locking(
{
save/RestoreV2_15/tensor_namesConst*
dtype0*
_output_shapes
:*)
value BBmatching_filenames_7
k
"save/RestoreV2_15/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_15	RestoreV2
save/Constsave/RestoreV2_15/tensor_names"save/RestoreV2_15/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_15Assignmatching_filenames_7save/RestoreV2_15*
use_locking(*
validate_shape( *
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_7
{
save/RestoreV2_16/tensor_namesConst*)
value BBmatching_filenames_8*
_output_shapes
:*
dtype0
k
"save/RestoreV2_16/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_16	RestoreV2
save/Constsave/RestoreV2_16/tensor_names"save/RestoreV2_16/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_16Assignmatching_filenames_8save/RestoreV2_16*
_output_shapes
:*
validate_shape( *'
_class
loc:@matching_filenames_8*
T0*
use_locking(
­
save/restore_allNoOp^save/Assign^save/Assign_1^save/Assign_2^save/Assign_3^save/Assign_4^save/Assign_5^save/Assign_6^save/Assign_7^save/Assign_8^save/Assign_9^save/Assign_10^save/Assign_11^save/Assign_12^save/Assign_13^save/Assign_14^save/Assign_15^save/Assign_16"РN?     НWuQ	ЛЗ)^ЁПжAJВЈ
0ё/
9
Add
x"T
y"T
z"T"
Ttype:
2	
h
All	
input

reduction_indices"Tidx

output
"
	keep_dimsbool( "
Tidxtype0:
2	

ApplyGradientDescent
var"T

alpha"T

delta"T
out"T"
Ttype:
2	"
use_lockingbool( 
P
Assert
	condition
	
data2T"
T
list(type)(0"
	summarizeint
x
Assign
ref"T

value"T

output_ref"T"	
Ttype"
validate_shapebool("
use_lockingbool(
{
BiasAdd

value"T	
bias"T
output"T"
Ttype:
2	"-
data_formatstringNHWC:
NHWCNCHW
{
BiasAddGrad
out_backprop"T
output"T"
Ttype:
2	"-
data_formatstringNHWC:
NHWCNCHW
R
BroadcastGradientArgs
s0"T
s1"T
r0"T
r1"T"
Ttype0:
2	
8
Cast	
x"SrcT	
y"DstT"
SrcTtype"
DstTtype
h
ConcatV2
values"T*N
axis"Tidx
output"T"
Nint(0"	
Ttype"
Tidxtype0:
2	
8
Const
output"dtype"
valuetensor"
dtypetype
Щ
Conv2D

input"T
filter"T
output"T"
Ttype:
2"
strides	list(int)"
use_cudnn_on_gpubool(""
paddingstring:
SAMEVALID"-
data_formatstringNHWC:
NHWCNCHW
я
Conv2DBackpropFilter

input"T
filter_sizes
out_backprop"T
output"T"
Ttype:
2"
strides	list(int)"
use_cudnn_on_gpubool(""
paddingstring:
SAMEVALID"-
data_formatstringNHWC:
NHWCNCHW
ю
Conv2DBackpropInput
input_sizes
filter"T
out_backprop"T
output"T"
Ttype:
2"
strides	list(int)"
use_cudnn_on_gpubool(""
paddingstring:
SAMEVALID"-
data_formatstringNHWC:
NHWCNCHW
Ы

DecodeJpeg
contents	
image"
channelsint "
ratioint"
fancy_upscalingbool("!
try_recover_truncatedbool( "#
acceptable_fractionfloat%  ?"

dct_methodstring 
Ў
FIFOQueueV2

handle"!
component_types
list(type)(0"
shapeslist(shape)
 ("
capacityintџџџџџџџџџ"
	containerstring "
shared_namestring 
4
Fill
dims

value"T
output"T"	
Ttype
>
FloorDiv
x"T
y"T
z"T"
Ttype:
2	
:
Greater
x"T
y"T
z
"
Ttype:
2		
?
GreaterEqual
x"T
y"T
z
"
Ttype:
2		
.
Identity

input"T
output"T"	
Ttype
7
Less
x"T
y"T
z
"
Ttype:
2		
o
MatMul
a"T
b"T
product"T"
transpose_abool( "
transpose_bbool( "
Ttype:

2
+
MatchingFiles
pattern
	filenames
О
MaxPool

input"T
output"T"
Ttype0:
2"
ksize	list(int)(0"
strides	list(int)(0""
paddingstring:
SAMEVALID"-
data_formatstringNHWC:
NHWCNCHW
ф
MaxPoolGrad

orig_input"T
orig_output"T	
grad"T
output"T"
ksize	list(int)(0"
strides	list(int)(0""
paddingstring:
SAMEVALID"-
data_formatstringNHWC:
NHWCNCHW"
Ttype0:
2
:
Maximum
x"T
y"T
z"T"
Ttype:	
2	
N
Merge
inputs"T*N
output"T
value_index"	
Ttype"
Nint(0
:
Minimum
x"T
y"T
z"T"
Ttype:	
2	
<
Mul
x"T
y"T
z"T"
Ttype:
2	
-
Neg
x"T
y"T"
Ttype:
	2	

NoOp
M
Pack
values"T*N
output"T"
Nint(0"	
Ttype"
axisint 
_
Pad

input"T
paddings"	Tpaddings
output"T"	
Ttype"
	Tpaddingstype0:
2	
?
QueueCloseV2

handle"#
cancel_pending_enqueuesbool( 

QueueDequeueManyV2

handle
n

components2component_types"!
component_types
list(type)(0"

timeout_msintџџџџџџџџџ
z
QueueEnqueueManyV2

handle

components2Tcomponents"
Tcomponents
list(type)(0"

timeout_msintџџџџџџџџџ
v
QueueEnqueueV2

handle

components2Tcomponents"
Tcomponents
list(type)(0"

timeout_msintџџџџџџџџџ
#
QueueSizeV2

handle
size
ј
RandomShuffleQueueV2

handle"!
component_types
list(type)(0"
shapeslist(shape)
 ("
capacityintџџџџџџџџџ"
min_after_dequeueint "
seedint "
seed2int "
	containerstring "
shared_namestring 
}
RandomUniform

shape"T
output"dtype"
seedint "
seed2int "
dtypetype:
2"
Ttype:
2	
G
ReaderReadV2
reader_handle
queue_handle
key	
value
=
RealDiv
x"T
y"T
z"T"
Ttype:
2	
A
Relu
features"T
activations"T"
Ttype:
2		
S
ReluGrad
	gradients"T
features"T
	backprops"T"
Ttype:
2		
[
Reshape
tensor"T
shape"Tshape
output"T"	
Ttype"
Tshapetype0:
2	
l
	RestoreV2

prefix
tensor_names
shape_and_slices
tensors2dtypes"
dtypes
list(type)(0
i
SaveV2

prefix
tensor_names
shape_and_slices
tensors2dtypes"
dtypes
list(type)(0
M
ScalarSummary
tags
values"T
summary"
Ttype:
2		
P
Shape

input"T
output"out_type"	
Ttype"
out_typetype0:
2	
O
Size

input"T
output"out_type"	
Ttype"
out_typetype0:
2	
a
Slice

input"T
begin"Index
size"Index
output"T"	
Ttype"
Indextype:
2	
8
Softmax
logits"T
softmax"T"
Ttype:
2
0
Square
x"T
y"T"
Ttype:
	2	
5
Sub
x"T
y"T
z"T"
Ttype:
	2	

Sum

input"T
reduction_indices"Tidx
output"T"
	keep_dimsbool( "
Ttype:
2	"
Tidxtype0:
2	
M
Switch	
data"T
pred

output_false"T
output_true"T"	
Ttype
c
Tile

input"T
	multiples"
Tmultiples
output"T"	
Ttype"

Tmultiplestype0:
2	
P
Unpack

value"T
output"T*num"
numint("	
Ttype"
axisint 
s

VariableV2
ref"dtype"
shapeshape"
dtypetype"
	containerstring "
shared_namestring 
]
WholeFileReaderV2
reader_handle"
	containerstring "
shared_namestring *1.0.12v1.0.0-65-g4763edf-dirtyЭ
v
(matching_filenames/MatchingFiles/patternConst*
valueB BTrain/0/*.jpg*
_output_shapes
: *
dtype0

 matching_filenames/MatchingFilesMatchingFiles(matching_filenames/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
z
matching_filenames
VariableV2*
_output_shapes
:*
	container *
dtype0*
shared_name *
shape:
з
matching_filenames/AssignAssignmatching_filenames matching_filenames/MatchingFiles*
use_locking(*
T0*%
_class
loc:@matching_filenames*
validate_shape( *#
_output_shapes
:џџџџџџџџџ

matching_filenames/readIdentitymatching_filenames*
_output_shapes
:*%
_class
loc:@matching_filenames*
T0
e
input_producer/SizeSizematching_filenames/read*
_output_shapes
: *
out_type0*
T0
Z
input_producer/Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
q
input_producer/GreaterGreaterinput_producer/Sizeinput_producer/Greater/y*
_output_shapes
: *
T0

input_producer/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

#input_producer/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

input_producer/Assert/AssertAssertinput_producer/Greater#input_producer/Assert/Assert/data_0*

T
2*
	summarize
~
input_producer/IdentityIdentitymatching_filenames/read^input_producer/Assert/Assert*
_output_shapes
:*
T0

input_producerFIFOQueueV2*
shapes
: *
shared_name *
capacity *
_output_shapes
: *
component_types
2*
	container 

)input_producer/input_producer_EnqueueManyQueueEnqueueManyV2input_producerinput_producer/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
b
#input_producer/input_producer_CloseQueueCloseV2input_producer*
cancel_pending_enqueues( 
d
%input_producer/input_producer_Close_1QueueCloseV2input_producer*
cancel_pending_enqueues(
Y
"input_producer/input_producer_SizeQueueSizeV2input_producer*
_output_shapes
: 
o
input_producer/CastCast"input_producer/input_producer_Size*
_output_shapes
: *

DstT0*

SrcT0
Y
input_producer/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *   =
e
input_producer/mulMulinput_producer/Castinput_producer/mul/y*
T0*
_output_shapes
: 

'input_producer/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*3
value*B( B"input_producer/fraction_of_32_full

"input_producer/fraction_of_32_fullScalarSummary'input_producer/fraction_of_32_full/tagsinput_producer/mul*
_output_shapes
: *
T0
b
WholeFileReaderV2WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
Y
ReaderReadV2ReaderReadV2WholeFileReaderV2input_producer*
_output_shapes
: : 
ш

DecodeJpeg
DecodeJpegReaderReadV2:1*
channels *
acceptable_fraction%  ?*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
try_recover_truncated( *
fancy_upscaling(*

dct_method 
O
ShapeShape
DecodeJpeg*
T0*
out_type0*
_output_shapes
:
W
assert_positive/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
k
 assert_positive/assert_less/LessLessassert_positive/ConstShape*
_output_shapes
:*
T0
k
!assert_positive/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
 
assert_positive/assert_less/AllAll assert_positive/assert_less/Less!assert_positive/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

(assert_positive/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

0assert_positive/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ѓ
)assert_positive/assert_less/Assert/AssertAssertassert_positive/assert_less/All0assert_positive/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Н
control_dependencyIdentity
DecodeJpeg*^assert_positive/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
Y
Shape_1Shapecontrol_dependency*
T0*
_output_shapes
:*
out_type0
V
unstackUnpackShape_1*	
num*
T0*

axis *
_output_shapes
: : : 
H
sub/xConst*
value
B :*
dtype0*
_output_shapes
: 
=
subSubsub/x	unstack:1*
_output_shapes
: *
T0
0
NegNegsub*
T0*
_output_shapes
: 
L

floordiv/yConst*
dtype0*
_output_shapes
: *
value	B :
F
floordivFloorDivNeg
floordiv/y*
_output_shapes
: *
T0
K
	Maximum/yConst*
value	B : *
_output_shapes
: *
dtype0
H
MaximumMaximumfloordiv	Maximum/y*
T0*
_output_shapes
: 
N
floordiv_1/yConst*
dtype0*
_output_shapes
: *
value	B :
J

floordiv_1FloorDivsubfloordiv_1/y*
_output_shapes
: *
T0
M
Maximum_1/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_1Maximum
floordiv_1Maximum_1/y*
_output_shapes
: *
T0
I
sub_1/xConst*
value	B :P*
dtype0*
_output_shapes
: 
?
sub_1Subsub_1/xunstack*
_output_shapes
: *
T0
4
Neg_1Negsub_1*
_output_shapes
: *
T0
N
floordiv_2/yConst*
value	B :*
dtype0*
_output_shapes
: 
L

floordiv_2FloorDivNeg_1floordiv_2/y*
_output_shapes
: *
T0
M
Maximum_2/yConst*
value	B : *
dtype0*
_output_shapes
: 
N
	Maximum_2Maximum
floordiv_2Maximum_2/y*
_output_shapes
: *
T0
N
floordiv_3/yConst*
value	B :*
_output_shapes
: *
dtype0
L

floordiv_3FloorDivsub_1floordiv_3/y*
_output_shapes
: *
T0
M
Maximum_3/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_3Maximum
floordiv_3Maximum_3/y*
T0*
_output_shapes
: 
K
	Minimum/xConst*
value	B :P*
dtype0*
_output_shapes
: 
G
MinimumMinimum	Minimum/xunstack*
T0*
_output_shapes
: 
N
Minimum_1/xConst*
value
B :*
dtype0*
_output_shapes
: 
M
	Minimum_1MinimumMinimum_1/x	unstack:1*
_output_shapes
: *
T0
Y
Shape_2Shapecontrol_dependency*
out_type0*
_output_shapes
:*
T0
Y
assert_positive_1/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
q
"assert_positive_1/assert_less/LessLessassert_positive_1/ConstShape_2*
_output_shapes
:*
T0
m
#assert_positive_1/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_1/assert_less/AllAll"assert_positive_1/assert_less/Less#assert_positive_1/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

*assert_positive_1/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_1/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_1/assert_less/Assert/AssertAssert!assert_positive_1/assert_less/All2assert_positive_1/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Y
Shape_3Shapecontrol_dependency*
out_type0*
_output_shapes
:*
T0
X
	unstack_1UnpackShape_3*	
num*
T0*
_output_shapes
: : : *

axis 
P
GreaterEqual/yConst*
dtype0*
_output_shapes
: *
value	B : 
V
GreaterEqualGreaterEqualMaximumGreaterEqual/y*
_output_shapes
: *
T0
g
Assert/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
o
Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
X
Assert/AssertAssertGreaterEqualAssert/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_1/yConst*
_output_shapes
: *
dtype0*
value	B : 
\
GreaterEqual_1GreaterEqual	Maximum_2GreaterEqual_1/y*
_output_shapes
: *
T0
j
Assert_1/ConstConst*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_1/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
^
Assert_1/AssertAssertGreaterEqual_1Assert_1/Assert/data_0*

T
2*
	summarize
K
	Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
I
GreaterGreater	Minimum_1	Greater/y*
_output_shapes
: *
T0
h
Assert_2/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
p
Assert_2/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
W
Assert_2/AssertAssertGreaterAssert_2/Assert/data_0*
	summarize*

T
2
M
Greater_1/yConst*
value	B : *
dtype0*
_output_shapes
: 
K
	Greater_1GreaterMinimumGreater_1/y*
_output_shapes
: *
T0
i
Assert_3/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
q
Assert_3/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
Y
Assert_3/AssertAssert	Greater_1Assert_3/Assert/data_0*
	summarize*

T
2
?
addAdd	Minimum_1Maximum*
_output_shapes
: *
T0
Q
GreaterEqual_2GreaterEqualunstack_1:1add*
_output_shapes
: *
T0
p
Assert_4/ConstConst*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
x
Assert_4/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
^
Assert_4/AssertAssertGreaterEqual_2Assert_4/Assert/data_0*

T
2*
	summarize
A
add_1AddMinimum	Maximum_2*
_output_shapes
: *
T0
Q
GreaterEqual_3GreaterEqual	unstack_1add_1*
_output_shapes
: *
T0
q
Assert_5/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
y
Assert_5/Assert/data_0Const*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
^
Assert_5/AssertAssertGreaterEqual_3Assert_5/Assert/data_0*

T
2*
	summarize
Г
control_dependency_1Identitycontrol_dependency,^assert_positive_1/assert_less/Assert/Assert^Assert/Assert^Assert_1/Assert^Assert_2/Assert^Assert_3/Assert^Assert_4/Assert^Assert_5/Assert*
T0*
_class
loc:@DecodeJpeg*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
I
stack/2Const*
_output_shapes
: *
dtype0*
value	B : 
d
stackPack	Maximum_2Maximumstack/2*

axis *
_output_shapes
:*
T0*
N
T
	stack_1/2Const*
_output_shapes
: *
dtype0*
valueB :
џџџџџџџџџ
h
stack_1PackMinimum	Minimum_1	stack_1/2*
_output_shapes
:*
N*

axis *
T0

SliceSlicecontrol_dependency_1stackstack_1*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
L
Shape_4ShapeSlice*
T0*
out_type0*
_output_shapes
:
Y
assert_positive_2/ConstConst*
value	B : *
_output_shapes
: *
dtype0
q
"assert_positive_2/assert_less/LessLessassert_positive_2/ConstShape_4*
_output_shapes
:*
T0
m
#assert_positive_2/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
І
!assert_positive_2/assert_less/AllAll"assert_positive_2/assert_less/Less#assert_positive_2/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

*assert_positive_2/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_2/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Љ
+assert_positive_2/assert_less/Assert/AssertAssert!assert_positive_2/assert_less/All2assert_positive_2/assert_less/Assert/Assert/data_0*

T
2*
	summarize
L
Shape_5ShapeSlice*
out_type0*
_output_shapes
:*
T0
X
	unstack_2UnpackShape_5*

axis *
_output_shapes
: : : *	
num*
T0
J
sub_2/xConst*
dtype0*
_output_shapes
: *
value
B :
A
sub_2Subsub_2/x	Maximum_1*
_output_shapes
: *
T0
A
sub_3Subsub_2unstack_2:1*
T0*
_output_shapes
: 
I
sub_4/xConst*
value	B :P*
_output_shapes
: *
dtype0
A
sub_4Subsub_4/x	Maximum_3*
T0*
_output_shapes
: 
?
sub_5Subsub_4	unstack_2*
T0*
_output_shapes
: 
R
GreaterEqual_4/yConst*
_output_shapes
: *
dtype0*
value	B : 
\
GreaterEqual_4GreaterEqual	Maximum_3GreaterEqual_4/y*
T0*
_output_shapes
: 
i
Assert_6/ConstConst*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
q
Assert_6/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
^
Assert_6/AssertAssertGreaterEqual_4Assert_6/Assert/data_0*
	summarize*

T
2
R
GreaterEqual_5/yConst*
_output_shapes
: *
dtype0*
value	B : 
\
GreaterEqual_5GreaterEqual	Maximum_1GreaterEqual_5/y*
T0*
_output_shapes
: 
h
Assert_7/ConstConst**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
p
Assert_7/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
^
Assert_7/AssertAssertGreaterEqual_5Assert_7/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_6/yConst*
value	B : *
_output_shapes
: *
dtype0
X
GreaterEqual_6GreaterEqualsub_3GreaterEqual_6/y*
T0*
_output_shapes
: 
o
Assert_8/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
w
Assert_8/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
^
Assert_8/AssertAssertGreaterEqual_6Assert_8/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_7/yConst*
dtype0*
_output_shapes
: *
value	B : 
X
GreaterEqual_7GreaterEqualsub_5GreaterEqual_7/y*
T0*
_output_shapes
: 
p
Assert_9/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_9/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
^
Assert_9/AssertAssertGreaterEqual_7Assert_9/Assert/data_0*
	summarize*

T
2
џ
control_dependency_2IdentitySlice,^assert_positive_2/assert_less/Assert/Assert^Assert_6/Assert^Assert_7/Assert^Assert_8/Assert^Assert_9/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class

loc:@Slice
K
	stack_2/4Const*
value	B : *
_output_shapes
: *
dtype0
K
	stack_2/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_2Pack	Maximum_3sub_5	Maximum_1sub_3	stack_2/4	stack_2/5*
_output_shapes
:*
N*

axis *
T0
^
Reshape/shapeConst*
_output_shapes
:*
dtype0*
valueB"      
a
ReshapeReshapestack_2Reshape/shape*
_output_shapes

:*
Tshape0*
T0
q
PadPadcontrol_dependency_2Reshape*,
_output_shapes
:Pџџџџџџџџџ*
	Tpaddings0*
T0
J
Shape_6ShapePad*
T0*
_output_shapes
:*
out_type0
X
	unstack_3UnpackShape_6*
_output_shapes
: : : *

axis *	
num*
T0
t
control_dependency_3IdentityPad*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad*
T0
d
Reshape_1/shapeConst*!
valueB"P         *
dtype0*
_output_shapes
:
w
	Reshape_1Reshapecontrol_dependency_3Reshape_1/shape*
T0*#
_output_shapes
:P*
Tshape0
W
ToFloatCast	Reshape_1*#
_output_shapes
:P*

DstT0*

SrcT0
J
div/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
L
divRealDivToFloatdiv/y*
T0*#
_output_shapes
:P
L
sub_6/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
H
sub_6Subdivsub_6/y*#
_output_shapes
:P*
T0
t
shuffle_batch/ConstConst*
_output_shapes
:*
dtype0*-
value$B""      №?                
W
shuffle_batch/Const_1Const*
dtype0
*
_output_shapes
: *
value	B
 Z
і
"shuffle_batch/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
	container *
seed2 *
shared_name *

seed *
_output_shapes
: *
component_types
2*
min_after_dequeue
*
capacity
t
shuffle_batch/cond/SwitchSwitchshuffle_batch/Const_1shuffle_batch/Const_1*
T0
*
_output_shapes
: : 
e
shuffle_batch/cond/switch_tIdentityshuffle_batch/cond/Switch:1*
_output_shapes
: *
T0

c
shuffle_batch/cond/switch_fIdentityshuffle_batch/cond/Switch*
T0
*
_output_shapes
: 
^
shuffle_batch/cond/pred_idIdentityshuffle_batch/Const_1*
T0
*
_output_shapes
: 
к
6shuffle_batch/cond/random_shuffle_queue_enqueue/SwitchSwitch"shuffle_batch/random_shuffle_queueshuffle_batch/cond/pred_id*
T0*
_output_shapes
: : *5
_class+
)'loc:@shuffle_batch/random_shuffle_queue
М
8shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_6shuffle_batch/cond/pred_id*
_class

loc:@sub_6*2
_output_shapes 
:P:P*
T0
Ц
8shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch/Constshuffle_batch/cond/pred_id*
T0* 
_output_shapes
::*&
_class
loc:@shuffle_batch/Const
Ѕ
/shuffle_batch/cond/random_shuffle_queue_enqueueQueueEnqueueV28shuffle_batch/cond/random_shuffle_queue_enqueue/Switch:1:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1:1:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
б
%shuffle_batch/cond/control_dependencyIdentityshuffle_batch/cond/switch_t0^shuffle_batch/cond/random_shuffle_queue_enqueue*.
_class$
" loc:@shuffle_batch/cond/switch_t*
_output_shapes
: *
T0

=
shuffle_batch/cond/NoOpNoOp^shuffle_batch/cond/switch_f
Л
'shuffle_batch/cond/control_dependency_1Identityshuffle_batch/cond/switch_f^shuffle_batch/cond/NoOp*.
_class$
" loc:@shuffle_batch/cond/switch_f*
_output_shapes
: *
T0


shuffle_batch/cond/MergeMerge'shuffle_batch/cond/control_dependency_1%shuffle_batch/cond/control_dependency*
N*
T0
*
_output_shapes
: : 
{
(shuffle_batch/random_shuffle_queue_CloseQueueCloseV2"shuffle_batch/random_shuffle_queue*
cancel_pending_enqueues( 
}
*shuffle_batch/random_shuffle_queue_Close_1QueueCloseV2"shuffle_batch/random_shuffle_queue*
cancel_pending_enqueues(
r
'shuffle_batch/random_shuffle_queue_SizeQueueSizeV2"shuffle_batch/random_shuffle_queue*
_output_shapes
: 
U
shuffle_batch/sub/yConst*
dtype0*
_output_shapes
: *
value	B :

w
shuffle_batch/subSub'shuffle_batch/random_shuffle_queue_Sizeshuffle_batch/sub/y*
_output_shapes
: *
T0
Y
shuffle_batch/Maximum/xConst*
value	B : *
dtype0*
_output_shapes
: 
m
shuffle_batch/MaximumMaximumshuffle_batch/Maximum/xshuffle_batch/sub*
_output_shapes
: *
T0
a
shuffle_batch/CastCastshuffle_batch/Maximum*

SrcT0*
_output_shapes
: *

DstT0
X
shuffle_batch/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
b
shuffle_batch/mulMulshuffle_batch/Castshuffle_batch/mul/y*
_output_shapes
: *
T0

.shuffle_batch/fraction_over_10_of_12_full/tagsConst*:
value1B/ B)shuffle_batch/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 

)shuffle_batch/fraction_over_10_of_12_fullScalarSummary.shuffle_batch/fraction_over_10_of_12_full/tagsshuffle_batch/mul*
_output_shapes
: *
T0
Q
shuffle_batch/nConst*
value	B :*
_output_shapes
: *
dtype0
С
shuffle_batchQueueDequeueManyV2"shuffle_batch/random_shuffle_queueshuffle_batch/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
x
*matching_filenames_1/MatchingFiles/patternConst*
dtype0*
_output_shapes
: *
valueB BTrain/1/*.jpg

"matching_filenames_1/MatchingFilesMatchingFiles*matching_filenames_1/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_1
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_1/AssignAssignmatching_filenames_1"matching_filenames_1/MatchingFiles*
use_locking(*
T0*'
_class
loc:@matching_filenames_1*
validate_shape( *#
_output_shapes
:џџџџџџџџџ

matching_filenames_1/readIdentitymatching_filenames_1*
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_1
i
input_producer_1/SizeSizematching_filenames_1/read*
_output_shapes
: *
out_type0*
T0
\
input_producer_1/Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
w
input_producer_1/GreaterGreaterinput_producer_1/Sizeinput_producer_1/Greater/y*
T0*
_output_shapes
: 

input_producer_1/Assert/ConstConst*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_1/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

input_producer_1/Assert/AssertAssertinput_producer_1/Greater%input_producer_1/Assert/Assert/data_0*
	summarize*

T
2

input_producer_1/IdentityIdentitymatching_filenames_1/read^input_producer_1/Assert/Assert*
_output_shapes
:*
T0

input_producer_1FIFOQueueV2*
shapes
: *
_output_shapes
: *
component_types
2*
shared_name *
	container *
capacity 
Ё
-input_producer_1/input_producer_1_EnqueueManyQueueEnqueueManyV2input_producer_1input_producer_1/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_1/input_producer_1_CloseQueueCloseV2input_producer_1*
cancel_pending_enqueues( 
j
)input_producer_1/input_producer_1_Close_1QueueCloseV2input_producer_1*
cancel_pending_enqueues(
_
&input_producer_1/input_producer_1_SizeQueueSizeV2input_producer_1*
_output_shapes
: 
u
input_producer_1/CastCast&input_producer_1/input_producer_1_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_1/mul/yConst*
valueB
 *   =*
dtype0*
_output_shapes
: 
k
input_producer_1/mulMulinput_producer_1/Castinput_producer_1/mul/y*
T0*
_output_shapes
: 

)input_producer_1/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_1/fraction_of_32_full*
_output_shapes
: *
dtype0

$input_producer_1/fraction_of_32_fullScalarSummary)input_producer_1/fraction_of_32_full/tagsinput_producer_1/mul*
T0*
_output_shapes
: 
d
WholeFileReaderV2_1WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_1ReaderReadV2WholeFileReaderV2_1input_producer_1*
_output_shapes
: : 
ь
DecodeJpeg_1
DecodeJpegReaderReadV2_1:1*
fancy_upscaling(*

dct_method *
try_recover_truncated( *
channels *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
acceptable_fraction%  ?
S
Shape_7ShapeDecodeJpeg_1*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_3/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
q
"assert_positive_3/assert_less/LessLessassert_positive_3/ConstShape_7*
_output_shapes
:*
T0
m
#assert_positive_3/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
І
!assert_positive_3/assert_less/AllAll"assert_positive_3/assert_less/Less#assert_positive_3/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_3/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_3/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_3/assert_less/Assert/AssertAssert!assert_positive_3/assert_less/All2assert_positive_3/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Х
control_dependency_4IdentityDecodeJpeg_1,^assert_positive_3/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg_1*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
[
Shape_8Shapecontrol_dependency_4*
T0*
out_type0*
_output_shapes
:
X
	unstack_4UnpackShape_8*	
num*
T0*
_output_shapes
: : : *

axis 
J
sub_7/xConst*
value
B :*
_output_shapes
: *
dtype0
C
sub_7Subsub_7/xunstack_4:1*
_output_shapes
: *
T0
4
Neg_2Negsub_7*
T0*
_output_shapes
: 
N
floordiv_4/yConst*
_output_shapes
: *
dtype0*
value	B :
L

floordiv_4FloorDivNeg_2floordiv_4/y*
T0*
_output_shapes
: 
M
Maximum_4/yConst*
dtype0*
_output_shapes
: *
value	B : 
N
	Maximum_4Maximum
floordiv_4Maximum_4/y*
_output_shapes
: *
T0
N
floordiv_5/yConst*
_output_shapes
: *
dtype0*
value	B :
L

floordiv_5FloorDivsub_7floordiv_5/y*
T0*
_output_shapes
: 
M
Maximum_5/yConst*
dtype0*
_output_shapes
: *
value	B : 
N
	Maximum_5Maximum
floordiv_5Maximum_5/y*
T0*
_output_shapes
: 
I
sub_8/xConst*
_output_shapes
: *
dtype0*
value	B :P
A
sub_8Subsub_8/x	unstack_4*
_output_shapes
: *
T0
4
Neg_3Negsub_8*
T0*
_output_shapes
: 
N
floordiv_6/yConst*
value	B :*
dtype0*
_output_shapes
: 
L

floordiv_6FloorDivNeg_3floordiv_6/y*
_output_shapes
: *
T0
M
Maximum_6/yConst*
value	B : *
_output_shapes
: *
dtype0
N
	Maximum_6Maximum
floordiv_6Maximum_6/y*
_output_shapes
: *
T0
N
floordiv_7/yConst*
dtype0*
_output_shapes
: *
value	B :
L

floordiv_7FloorDivsub_8floordiv_7/y*
T0*
_output_shapes
: 
M
Maximum_7/yConst*
_output_shapes
: *
dtype0*
value	B : 
N
	Maximum_7Maximum
floordiv_7Maximum_7/y*
_output_shapes
: *
T0
M
Minimum_2/xConst*
dtype0*
_output_shapes
: *
value	B :P
M
	Minimum_2MinimumMinimum_2/x	unstack_4*
_output_shapes
: *
T0
N
Minimum_3/xConst*
_output_shapes
: *
dtype0*
value
B :
O
	Minimum_3MinimumMinimum_3/xunstack_4:1*
T0*
_output_shapes
: 
[
Shape_9Shapecontrol_dependency_4*
T0*
out_type0*
_output_shapes
:
Y
assert_positive_4/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
q
"assert_positive_4/assert_less/LessLessassert_positive_4/ConstShape_9*
_output_shapes
:*
T0
m
#assert_positive_4/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_4/assert_less/AllAll"assert_positive_4/assert_less/Less#assert_positive_4/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_4/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_4/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Љ
+assert_positive_4/assert_less/Assert/AssertAssert!assert_positive_4/assert_less/All2assert_positive_4/assert_less/Assert/Assert/data_0*

T
2*
	summarize
\
Shape_10Shapecontrol_dependency_4*
T0*
_output_shapes
:*
out_type0
Y
	unstack_5UnpackShape_10*
_output_shapes
: : : *

axis *	
num*
T0
R
GreaterEqual_8/yConst*
dtype0*
_output_shapes
: *
value	B : 
\
GreaterEqual_8GreaterEqual	Maximum_4GreaterEqual_8/y*
T0*
_output_shapes
: 
j
Assert_10/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_10/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
`
Assert_10/AssertAssertGreaterEqual_8Assert_10/Assert/data_0*

T
2*
	summarize
R
GreaterEqual_9/yConst*
value	B : *
dtype0*
_output_shapes
: 
\
GreaterEqual_9GreaterEqual	Maximum_6GreaterEqual_9/y*
T0*
_output_shapes
: 
k
Assert_11/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_11/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
`
Assert_11/AssertAssertGreaterEqual_9Assert_11/Assert/data_0*
	summarize*

T
2
M
Greater_2/yConst*
value	B : *
dtype0*
_output_shapes
: 
M
	Greater_2Greater	Minimum_3Greater_2/y*
_output_shapes
: *
T0
i
Assert_12/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
q
Assert_12/Assert/data_0Const**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
[
Assert_12/AssertAssert	Greater_2Assert_12/Assert/data_0*
	summarize*

T
2
M
Greater_3/yConst*
_output_shapes
: *
dtype0*
value	B : 
M
	Greater_3Greater	Minimum_2Greater_3/y*
T0*
_output_shapes
: 
j
Assert_13/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_13/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
[
Assert_13/AssertAssert	Greater_3Assert_13/Assert/data_0*

T
2*
	summarize
C
add_2Add	Minimum_3	Maximum_4*
_output_shapes
: *
T0
T
GreaterEqual_10GreaterEqualunstack_5:1add_2*
_output_shapes
: *
T0
q
Assert_14/ConstConst*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
y
Assert_14/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_14/AssertAssertGreaterEqual_10Assert_14/Assert/data_0*
	summarize*

T
2
C
add_3Add	Minimum_2	Maximum_6*
T0*
_output_shapes
: 
R
GreaterEqual_11GreaterEqual	unstack_5add_3*
T0*
_output_shapes
: 
r
Assert_15/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_15/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_15/AssertAssertGreaterEqual_11Assert_15/Assert/data_0*

T
2*
	summarize
П
control_dependency_5Identitycontrol_dependency_4,^assert_positive_4/assert_less/Assert/Assert^Assert_10/Assert^Assert_11/Assert^Assert_12/Assert^Assert_13/Assert^Assert_14/Assert^Assert_15/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_1*
T0
K
	stack_3/2Const*
value	B : *
dtype0*
_output_shapes
: 
j
stack_3Pack	Maximum_6	Maximum_4	stack_3/2*
N*
T0*
_output_shapes
:*

axis 
T
	stack_4/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
j
stack_4Pack	Minimum_2	Minimum_3	stack_4/2*

axis *
_output_shapes
:*
T0*
N

Slice_1Slicecontrol_dependency_5stack_3stack_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_11ShapeSlice_1*
out_type0*
_output_shapes
:*
T0
Y
assert_positive_5/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
r
"assert_positive_5/assert_less/LessLessassert_positive_5/ConstShape_11*
_output_shapes
:*
T0
m
#assert_positive_5/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_5/assert_less/AllAll"assert_positive_5/assert_less/Less#assert_positive_5/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_5/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

2assert_positive_5/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_5/assert_less/Assert/AssertAssert!assert_positive_5/assert_less/All2assert_positive_5/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_12ShapeSlice_1*
T0*
_output_shapes
:*
out_type0
Y
	unstack_6UnpackShape_12*	
num*
T0*
_output_shapes
: : : *

axis 
J
sub_9/xConst*
value
B :*
dtype0*
_output_shapes
: 
A
sub_9Subsub_9/x	Maximum_5*
T0*
_output_shapes
: 
B
sub_10Subsub_9unstack_6:1*
_output_shapes
: *
T0
J
sub_11/xConst*
dtype0*
_output_shapes
: *
value	B :P
C
sub_11Subsub_11/x	Maximum_7*
_output_shapes
: *
T0
A
sub_12Subsub_11	unstack_6*
T0*
_output_shapes
: 
S
GreaterEqual_12/yConst*
value	B : *
dtype0*
_output_shapes
: 
^
GreaterEqual_12GreaterEqual	Maximum_7GreaterEqual_12/y*
T0*
_output_shapes
: 
j
Assert_16/ConstConst*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
r
Assert_16/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_16/AssertAssertGreaterEqual_12Assert_16/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_13/yConst*
dtype0*
_output_shapes
: *
value	B : 
^
GreaterEqual_13GreaterEqual	Maximum_5GreaterEqual_13/y*
_output_shapes
: *
T0
i
Assert_17/ConstConst**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
q
Assert_17/Assert/data_0Const*
_output_shapes
: *
dtype0**
value!B Boffset_width must be >= 0
a
Assert_17/AssertAssertGreaterEqual_13Assert_17/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_14/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_14GreaterEqualsub_10GreaterEqual_14/y*
T0*
_output_shapes
: 
p
Assert_18/ConstConst*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
x
Assert_18/Assert/data_0Const*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_18/AssertAssertGreaterEqual_14Assert_18/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_15/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_15GreaterEqualsub_12GreaterEqual_15/y*
_output_shapes
: *
T0
q
Assert_19/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!height must be <= target - offset
y
Assert_19/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!height must be <= target - offset
a
Assert_19/AssertAssertGreaterEqual_15Assert_19/Assert/data_0*

T
2*
	summarize

control_dependency_6IdentitySlice_1,^assert_positive_5/assert_less/Assert/Assert^Assert_16/Assert^Assert_17/Assert^Assert_18/Assert^Assert_19/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_1
K
	stack_5/4Const*
value	B : *
_output_shapes
: *
dtype0
K
	stack_5/5Const*
value	B : *
_output_shapes
: *
dtype0

stack_5Pack	Maximum_7sub_12	Maximum_5sub_10	stack_5/4	stack_5/5*

axis *
_output_shapes
:*
T0*
N
`
Reshape_2/shapeConst*
_output_shapes
:*
dtype0*
valueB"      
e
	Reshape_2Reshapestack_5Reshape_2/shape*
T0*
Tshape0*
_output_shapes

:
u
Pad_1Padcontrol_dependency_6	Reshape_2*,
_output_shapes
:Pџџџџџџџџџ*
T0*
	Tpaddings0
M
Shape_13ShapePad_1*
T0*
out_type0*
_output_shapes
:
Y
	unstack_7UnpackShape_13*

axis *
_output_shapes
: : : *	
num*
T0
x
control_dependency_7IdentityPad_1*
_class

loc:@Pad_1*,
_output_shapes
:Pџџџџџџџџџ*
T0
d
Reshape_3/shapeConst*
dtype0*
_output_shapes
:*!
valueB"P         
w
	Reshape_3Reshapecontrol_dependency_7Reshape_3/shape*
T0*
Tshape0*#
_output_shapes
:P
Y
	ToFloat_1Cast	Reshape_3*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_1/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
R
div_1RealDiv	ToFloat_1div_1/y*#
_output_shapes
:P*
T0
M
sub_13/yConst*
valueB
 *   ?*
dtype0*
_output_shapes
: 
L
sub_13Subdiv_1sub_13/y*
T0*#
_output_shapes
:P
v
shuffle_batch_1/ConstConst*
dtype0*
_output_shapes
:*-
value$B""              №?        
Y
shuffle_batch_1/Const_1Const*
value	B
 Z*
_output_shapes
: *
dtype0

ј
$shuffle_batch_1/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
	container *
seed2 *
min_after_dequeue
*
capacity*
shared_name *

seed 
z
shuffle_batch_1/cond/SwitchSwitchshuffle_batch_1/Const_1shuffle_batch_1/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_1/cond/switch_tIdentityshuffle_batch_1/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_1/cond/switch_fIdentityshuffle_batch_1/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_1/cond/pred_idIdentityshuffle_batch_1/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_1/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_1/random_shuffle_queueshuffle_batch_1/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_1/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_13shuffle_batch_1/cond/pred_id*
T0*
_class
loc:@sub_13*2
_output_shapes 
:P:P
Ю
:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_1/Constshuffle_batch_1/cond/pred_id*(
_class
loc:@shuffle_batch_1/Const* 
_output_shapes
::*
T0
­
1shuffle_batch_1/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_1/cond/control_dependencyIdentityshuffle_batch_1/cond/switch_t2^shuffle_batch_1/cond/random_shuffle_queue_enqueue*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_1/cond/switch_t*
T0

A
shuffle_batch_1/cond/NoOpNoOp^shuffle_batch_1/cond/switch_f
У
)shuffle_batch_1/cond/control_dependency_1Identityshuffle_batch_1/cond/switch_f^shuffle_batch_1/cond/NoOp*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_1/cond/switch_f*
T0

Ѓ
shuffle_batch_1/cond/MergeMerge)shuffle_batch_1/cond/control_dependency_1'shuffle_batch_1/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_1/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_1/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_1/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_1/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_1/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_1/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_1/sub/yConst*
value	B :
*
dtype0*
_output_shapes
: 
}
shuffle_batch_1/subSub)shuffle_batch_1/random_shuffle_queue_Sizeshuffle_batch_1/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_1/Maximum/xConst*
value	B : *
dtype0*
_output_shapes
: 
s
shuffle_batch_1/MaximumMaximumshuffle_batch_1/Maximum/xshuffle_batch_1/sub*
T0*
_output_shapes
: 
e
shuffle_batch_1/CastCastshuffle_batch_1/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_1/mul/yConst*
valueB
 *ЋЊЊ=*
_output_shapes
: *
dtype0
h
shuffle_batch_1/mulMulshuffle_batch_1/Castshuffle_batch_1/mul/y*
_output_shapes
: *
T0

0shuffle_batch_1/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_1/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_1/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_1/fraction_over_10_of_12_full/tagsshuffle_batch_1/mul*
T0*
_output_shapes
: 
S
shuffle_batch_1/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_1QueueDequeueManyV2$shuffle_batch_1/random_shuffle_queueshuffle_batch_1/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
x
*matching_filenames_2/MatchingFiles/patternConst*
valueB BTrain/2/*.jpg*
dtype0*
_output_shapes
: 

"matching_filenames_2/MatchingFilesMatchingFiles*matching_filenames_2/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_2
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_2/AssignAssignmatching_filenames_2"matching_filenames_2/MatchingFiles*
use_locking(*
T0*'
_class
loc:@matching_filenames_2*
validate_shape( *#
_output_shapes
:џџџџџџџџџ

matching_filenames_2/readIdentitymatching_filenames_2*'
_class
loc:@matching_filenames_2*
_output_shapes
:*
T0
i
input_producer_2/SizeSizematching_filenames_2/read*
out_type0*
_output_shapes
: *
T0
\
input_producer_2/Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
w
input_producer_2/GreaterGreaterinput_producer_2/Sizeinput_producer_2/Greater/y*
T0*
_output_shapes
: 

input_producer_2/Assert/ConstConst*
_output_shapes
: *
dtype0*G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_2/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_2/Assert/AssertAssertinput_producer_2/Greater%input_producer_2/Assert/Assert/data_0*
	summarize*

T
2

input_producer_2/IdentityIdentitymatching_filenames_2/read^input_producer_2/Assert/Assert*
_output_shapes
:*
T0

input_producer_2FIFOQueueV2*
shapes
: *
shared_name *
capacity *
	container *
_output_shapes
: *
component_types
2
Ё
-input_producer_2/input_producer_2_EnqueueManyQueueEnqueueManyV2input_producer_2input_producer_2/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_2/input_producer_2_CloseQueueCloseV2input_producer_2*
cancel_pending_enqueues( 
j
)input_producer_2/input_producer_2_Close_1QueueCloseV2input_producer_2*
cancel_pending_enqueues(
_
&input_producer_2/input_producer_2_SizeQueueSizeV2input_producer_2*
_output_shapes
: 
u
input_producer_2/CastCast&input_producer_2/input_producer_2_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_2/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_2/mulMulinput_producer_2/Castinput_producer_2/mul/y*
_output_shapes
: *
T0

)input_producer_2/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_2/fraction_of_32_full*
_output_shapes
: *
dtype0

$input_producer_2/fraction_of_32_fullScalarSummary)input_producer_2/fraction_of_32_full/tagsinput_producer_2/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_2WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
_
ReaderReadV2_2ReaderReadV2WholeFileReaderV2_2input_producer_2*
_output_shapes
: : 
ь
DecodeJpeg_2
DecodeJpegReaderReadV2_2:1*
acceptable_fraction%  ?*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
channels *
try_recover_truncated( *

dct_method *
fancy_upscaling(
T
Shape_14ShapeDecodeJpeg_2*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_6/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
r
"assert_positive_6/assert_less/LessLessassert_positive_6/ConstShape_14*
T0*
_output_shapes
:
m
#assert_positive_6/assert_less/ConstConst*
dtype0*
_output_shapes
:*
valueB: 
І
!assert_positive_6/assert_less/AllAll"assert_positive_6/assert_less/Less#assert_positive_6/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_6/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

2assert_positive_6/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Љ
+assert_positive_6/assert_less/Assert/AssertAssert!assert_positive_6/assert_less/All2assert_positive_6/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Х
control_dependency_8IdentityDecodeJpeg_2,^assert_positive_6/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg_2*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
\
Shape_15Shapecontrol_dependency_8*
out_type0*
_output_shapes
:*
T0
Y
	unstack_8UnpackShape_15*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_14/xConst*
value
B :*
_output_shapes
: *
dtype0
E
sub_14Subsub_14/xunstack_8:1*
_output_shapes
: *
T0
5
Neg_4Negsub_14*
_output_shapes
: *
T0
N
floordiv_8/yConst*
_output_shapes
: *
dtype0*
value	B :
L

floordiv_8FloorDivNeg_4floordiv_8/y*
T0*
_output_shapes
: 
M
Maximum_8/yConst*
_output_shapes
: *
dtype0*
value	B : 
N
	Maximum_8Maximum
floordiv_8Maximum_8/y*
T0*
_output_shapes
: 
N
floordiv_9/yConst*
_output_shapes
: *
dtype0*
value	B :
M

floordiv_9FloorDivsub_14floordiv_9/y*
T0*
_output_shapes
: 
M
Maximum_9/yConst*
dtype0*
_output_shapes
: *
value	B : 
N
	Maximum_9Maximum
floordiv_9Maximum_9/y*
_output_shapes
: *
T0
J
sub_15/xConst*
value	B :P*
dtype0*
_output_shapes
: 
C
sub_15Subsub_15/x	unstack_8*
T0*
_output_shapes
: 
5
Neg_5Negsub_15*
T0*
_output_shapes
: 
O
floordiv_10/yConst*
value	B :*
dtype0*
_output_shapes
: 
N
floordiv_10FloorDivNeg_5floordiv_10/y*
T0*
_output_shapes
: 
N
Maximum_10/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_10Maximumfloordiv_10Maximum_10/y*
T0*
_output_shapes
: 
O
floordiv_11/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_11FloorDivsub_15floordiv_11/y*
T0*
_output_shapes
: 
N
Maximum_11/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_11Maximumfloordiv_11Maximum_11/y*
T0*
_output_shapes
: 
M
Minimum_4/xConst*
dtype0*
_output_shapes
: *
value	B :P
M
	Minimum_4MinimumMinimum_4/x	unstack_8*
_output_shapes
: *
T0
N
Minimum_5/xConst*
value
B :*
dtype0*
_output_shapes
: 
O
	Minimum_5MinimumMinimum_5/xunstack_8:1*
T0*
_output_shapes
: 
\
Shape_16Shapecontrol_dependency_8*
_output_shapes
:*
out_type0*
T0
Y
assert_positive_7/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
r
"assert_positive_7/assert_less/LessLessassert_positive_7/ConstShape_16*
T0*
_output_shapes
:
m
#assert_positive_7/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
І
!assert_positive_7/assert_less/AllAll"assert_positive_7/assert_less/Less#assert_positive_7/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_7/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_7/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_7/assert_less/Assert/AssertAssert!assert_positive_7/assert_less/All2assert_positive_7/assert_less/Assert/Assert/data_0*
	summarize*

T
2
\
Shape_17Shapecontrol_dependency_8*
T0*
_output_shapes
:*
out_type0
Y
	unstack_9UnpackShape_17*

axis *
_output_shapes
: : : *	
num*
T0
S
GreaterEqual_16/yConst*
value	B : *
dtype0*
_output_shapes
: 
^
GreaterEqual_16GreaterEqual	Maximum_8GreaterEqual_16/y*
_output_shapes
: *
T0
j
Assert_20/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
r
Assert_20/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_20/AssertAssertGreaterEqual_16Assert_20/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_17/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_17GreaterEqual
Maximum_10GreaterEqual_17/y*
_output_shapes
: *
T0
k
Assert_21/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_21/Assert/data_0Const*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
a
Assert_21/AssertAssertGreaterEqual_17Assert_21/Assert/data_0*

T
2*
	summarize
M
Greater_4/yConst*
value	B : *
_output_shapes
: *
dtype0
M
	Greater_4Greater	Minimum_5Greater_4/y*
_output_shapes
: *
T0
i
Assert_22/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_22/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
[
Assert_22/AssertAssert	Greater_4Assert_22/Assert/data_0*
	summarize*

T
2
M
Greater_5/yConst*
_output_shapes
: *
dtype0*
value	B : 
M
	Greater_5Greater	Minimum_4Greater_5/y*
_output_shapes
: *
T0
j
Assert_23/ConstConst*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
r
Assert_23/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
[
Assert_23/AssertAssert	Greater_5Assert_23/Assert/data_0*

T
2*
	summarize
C
add_4Add	Minimum_5	Maximum_8*
T0*
_output_shapes
: 
T
GreaterEqual_18GreaterEqualunstack_9:1add_4*
T0*
_output_shapes
: 
q
Assert_24/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
y
Assert_24/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
a
Assert_24/AssertAssertGreaterEqual_18Assert_24/Assert/data_0*

T
2*
	summarize
D
add_5Add	Minimum_4
Maximum_10*
_output_shapes
: *
T0
R
GreaterEqual_19GreaterEqual	unstack_9add_5*
_output_shapes
: *
T0
r
Assert_25/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_25/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_25/AssertAssertGreaterEqual_19Assert_25/Assert/data_0*
	summarize*

T
2
П
control_dependency_9Identitycontrol_dependency_8,^assert_positive_7/assert_less/Assert/Assert^Assert_20/Assert^Assert_21/Assert^Assert_22/Assert^Assert_23/Assert^Assert_24/Assert^Assert_25/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_2
K
	stack_6/2Const*
dtype0*
_output_shapes
: *
value	B : 
k
stack_6Pack
Maximum_10	Maximum_8	stack_6/2*
T0*

axis *
N*
_output_shapes
:
T
	stack_7/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
j
stack_7Pack	Minimum_4	Minimum_5	stack_7/2*

axis *
_output_shapes
:*
T0*
N

Slice_2Slicecontrol_dependency_9stack_6stack_7*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_18ShapeSlice_2*
T0*
_output_shapes
:*
out_type0
Y
assert_positive_8/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
r
"assert_positive_8/assert_less/LessLessassert_positive_8/ConstShape_18*
_output_shapes
:*
T0
m
#assert_positive_8/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
І
!assert_positive_8/assert_less/AllAll"assert_positive_8/assert_less/Less#assert_positive_8/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

*assert_positive_8/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_8/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Љ
+assert_positive_8/assert_less/Assert/AssertAssert!assert_positive_8/assert_less/All2assert_positive_8/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_19ShapeSlice_2*
out_type0*
_output_shapes
:*
T0
Z

unstack_10UnpackShape_19*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_16/xConst*
value
B :*
dtype0*
_output_shapes
: 
C
sub_16Subsub_16/x	Maximum_9*
_output_shapes
: *
T0
D
sub_17Subsub_16unstack_10:1*
_output_shapes
: *
T0
J
sub_18/xConst*
_output_shapes
: *
dtype0*
value	B :P
D
sub_18Subsub_18/x
Maximum_11*
T0*
_output_shapes
: 
B
sub_19Subsub_18
unstack_10*
T0*
_output_shapes
: 
S
GreaterEqual_20/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_20GreaterEqual
Maximum_11GreaterEqual_20/y*
T0*
_output_shapes
: 
j
Assert_26/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
r
Assert_26/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
a
Assert_26/AssertAssertGreaterEqual_20Assert_26/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_21/yConst*
value	B : *
dtype0*
_output_shapes
: 
^
GreaterEqual_21GreaterEqual	Maximum_9GreaterEqual_21/y*
T0*
_output_shapes
: 
i
Assert_27/ConstConst*
_output_shapes
: *
dtype0**
value!B Boffset_width must be >= 0
q
Assert_27/Assert/data_0Const*
_output_shapes
: *
dtype0**
value!B Boffset_width must be >= 0
a
Assert_27/AssertAssertGreaterEqual_21Assert_27/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_22/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_22GreaterEqualsub_17GreaterEqual_22/y*
_output_shapes
: *
T0
p
Assert_28/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
x
Assert_28/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_28/AssertAssertGreaterEqual_22Assert_28/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_23/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_23GreaterEqualsub_19GreaterEqual_23/y*
T0*
_output_shapes
: 
q
Assert_29/ConstConst*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
y
Assert_29/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_29/AssertAssertGreaterEqual_23Assert_29/Assert/data_0*
	summarize*

T
2

control_dependency_10IdentitySlice_2,^assert_positive_8/assert_less/Assert/Assert^Assert_26/Assert^Assert_27/Assert^Assert_28/Assert^Assert_29/Assert*
T0*
_class
loc:@Slice_2*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
K
	stack_8/4Const*
value	B : *
_output_shapes
: *
dtype0
K
	stack_8/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_8Pack
Maximum_11sub_19	Maximum_9sub_17	stack_8/4	stack_8/5*
_output_shapes
:*
N*

axis *
T0
`
Reshape_4/shapeConst*
_output_shapes
:*
dtype0*
valueB"      
e
	Reshape_4Reshapestack_8Reshape_4/shape*
_output_shapes

:*
Tshape0*
T0
v
Pad_2Padcontrol_dependency_10	Reshape_4*,
_output_shapes
:Pџџџџџџџџџ*
T0*
	Tpaddings0
M
Shape_20ShapePad_2*
out_type0*
_output_shapes
:*
T0
Z

unstack_11UnpackShape_20*	
num*
T0*

axis *
_output_shapes
: : : 
y
control_dependency_11IdentityPad_2*
T0*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad_2
d
Reshape_5/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
x
	Reshape_5Reshapecontrol_dependency_11Reshape_5/shape*
Tshape0*#
_output_shapes
:P*
T0
Y
	ToFloat_2Cast	Reshape_5*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_2/yConst*
valueB
 *  C*
dtype0*
_output_shapes
: 
R
div_2RealDiv	ToFloat_2div_2/y*
T0*#
_output_shapes
:P
M
sub_20/yConst*
valueB
 *   ?*
_output_shapes
: *
dtype0
L
sub_20Subdiv_2sub_20/y*
T0*#
_output_shapes
:P
v
shuffle_batch_2/ConstConst*-
value$B""                      №?*
dtype0*
_output_shapes
:
Y
shuffle_batch_2/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_2/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
min_after_dequeue
*
capacity*
_output_shapes
: *
component_types
2*

seed *
shared_name *
	container *
seed2 
z
shuffle_batch_2/cond/SwitchSwitchshuffle_batch_2/Const_1shuffle_batch_2/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_2/cond/switch_tIdentityshuffle_batch_2/cond/Switch:1*
_output_shapes
: *
T0

g
shuffle_batch_2/cond/switch_fIdentityshuffle_batch_2/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_2/cond/pred_idIdentityshuffle_batch_2/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_2/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_2/random_shuffle_queueshuffle_batch_2/cond/pred_id*
_output_shapes
: : *7
_class-
+)loc:@shuffle_batch_2/random_shuffle_queue*
T0
Т
:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_20shuffle_batch_2/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_20
Ю
:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_2/Constshuffle_batch_2/cond/pred_id*
T0* 
_output_shapes
::*(
_class
loc:@shuffle_batch_2/Const
­
1shuffle_batch_2/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_2/cond/control_dependencyIdentityshuffle_batch_2/cond/switch_t2^shuffle_batch_2/cond/random_shuffle_queue_enqueue*0
_class&
$"loc:@shuffle_batch_2/cond/switch_t*
_output_shapes
: *
T0

A
shuffle_batch_2/cond/NoOpNoOp^shuffle_batch_2/cond/switch_f
У
)shuffle_batch_2/cond/control_dependency_1Identityshuffle_batch_2/cond/switch_f^shuffle_batch_2/cond/NoOp*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_2/cond/switch_f*
T0

Ѓ
shuffle_batch_2/cond/MergeMerge)shuffle_batch_2/cond/control_dependency_1'shuffle_batch_2/cond/control_dependency*
N*
T0
*
_output_shapes
: : 

*shuffle_batch_2/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_2/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_2/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_2/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_2/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_2/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_2/sub/yConst*
value	B :
*
_output_shapes
: *
dtype0
}
shuffle_batch_2/subSub)shuffle_batch_2/random_shuffle_queue_Sizeshuffle_batch_2/sub/y*
T0*
_output_shapes
: 
[
shuffle_batch_2/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
s
shuffle_batch_2/MaximumMaximumshuffle_batch_2/Maximum/xshuffle_batch_2/sub*
_output_shapes
: *
T0
e
shuffle_batch_2/CastCastshuffle_batch_2/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_2/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *ЋЊЊ=
h
shuffle_batch_2/mulMulshuffle_batch_2/Castshuffle_batch_2/mul/y*
_output_shapes
: *
T0

0shuffle_batch_2/fraction_over_10_of_12_full/tagsConst*
_output_shapes
: *
dtype0*<
value3B1 B+shuffle_batch_2/fraction_over_10_of_12_full
Є
+shuffle_batch_2/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_2/fraction_over_10_of_12_full/tagsshuffle_batch_2/mul*
_output_shapes
: *
T0
S
shuffle_batch_2/nConst*
_output_shapes
: *
dtype0*
value	B :
Ч
shuffle_batch_2QueueDequeueManyV2$shuffle_batch_2/random_shuffle_queueshuffle_batch_2/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
M
concat/axisConst*
dtype0*
_output_shapes
: *
value	B : 

concatConcatV2shuffle_batchshuffle_batch_1shuffle_batch_2concat/axis*'
_output_shapes
:P*
N*
T0*

Tidx0
O
concat_1/axisConst*
value	B : *
_output_shapes
: *
dtype0

concat_1ConcatV2shuffle_batch:1shuffle_batch_1:1shuffle_batch_2:1concat_1/axis*
_output_shapes

:*
N*
T0*

Tidx0
x
*matching_filenames_3/MatchingFiles/patternConst*
dtype0*
_output_shapes
: *
valueB BValid/0/*.jpg

"matching_filenames_3/MatchingFilesMatchingFiles*matching_filenames_3/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_3
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_3/AssignAssignmatching_filenames_3"matching_filenames_3/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_3

matching_filenames_3/readIdentitymatching_filenames_3*'
_class
loc:@matching_filenames_3*
_output_shapes
:*
T0
i
input_producer_3/SizeSizematching_filenames_3/read*
T0*
out_type0*
_output_shapes
: 
\
input_producer_3/Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
w
input_producer_3/GreaterGreaterinput_producer_3/Sizeinput_producer_3/Greater/y*
T0*
_output_shapes
: 

input_producer_3/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
dtype0*
_output_shapes
: 

%input_producer_3/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

input_producer_3/Assert/AssertAssertinput_producer_3/Greater%input_producer_3/Assert/Assert/data_0*
	summarize*

T
2

input_producer_3/IdentityIdentitymatching_filenames_3/read^input_producer_3/Assert/Assert*
_output_shapes
:*
T0

input_producer_3FIFOQueueV2*
shapes
: *
capacity *
	container *
shared_name *
_output_shapes
: *
component_types
2
Ё
-input_producer_3/input_producer_3_EnqueueManyQueueEnqueueManyV2input_producer_3input_producer_3/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_3/input_producer_3_CloseQueueCloseV2input_producer_3*
cancel_pending_enqueues( 
j
)input_producer_3/input_producer_3_Close_1QueueCloseV2input_producer_3*
cancel_pending_enqueues(
_
&input_producer_3/input_producer_3_SizeQueueSizeV2input_producer_3*
_output_shapes
: 
u
input_producer_3/CastCast&input_producer_3/input_producer_3_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_3/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *   =
k
input_producer_3/mulMulinput_producer_3/Castinput_producer_3/mul/y*
T0*
_output_shapes
: 

)input_producer_3/fraction_of_32_full/tagsConst*
dtype0*
_output_shapes
: *5
value,B* B$input_producer_3/fraction_of_32_full

$input_producer_3/fraction_of_32_fullScalarSummary)input_producer_3/fraction_of_32_full/tagsinput_producer_3/mul*
T0*
_output_shapes
: 
d
WholeFileReaderV2_3WholeFileReaderV2*
shared_name *
_output_shapes
: *
	container 
_
ReaderReadV2_3ReaderReadV2WholeFileReaderV2_3input_producer_3*
_output_shapes
: : 
ь
DecodeJpeg_3
DecodeJpegReaderReadV2_3:1*
acceptable_fraction%  ?*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
channels *
try_recover_truncated( *

dct_method *
fancy_upscaling(
T
Shape_21ShapeDecodeJpeg_3*
T0*
_output_shapes
:*
out_type0
Y
assert_positive_9/ConstConst*
value	B : *
_output_shapes
: *
dtype0
r
"assert_positive_9/assert_less/LessLessassert_positive_9/ConstShape_21*
_output_shapes
:*
T0
m
#assert_positive_9/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
І
!assert_positive_9/assert_less/AllAll"assert_positive_9/assert_less/Less#assert_positive_9/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

*assert_positive_9/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

2assert_positive_9/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Љ
+assert_positive_9/assert_less/Assert/AssertAssert!assert_positive_9/assert_less/All2assert_positive_9/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ц
control_dependency_12IdentityDecodeJpeg_3,^assert_positive_9/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg_3*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
]
Shape_22Shapecontrol_dependency_12*
out_type0*
_output_shapes
:*
T0
Z

unstack_12UnpackShape_22*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_21/xConst*
dtype0*
_output_shapes
: *
value
B :
F
sub_21Subsub_21/xunstack_12:1*
T0*
_output_shapes
: 
5
Neg_6Negsub_21*
_output_shapes
: *
T0
O
floordiv_12/yConst*
value	B :*
dtype0*
_output_shapes
: 
N
floordiv_12FloorDivNeg_6floordiv_12/y*
T0*
_output_shapes
: 
N
Maximum_12/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_12Maximumfloordiv_12Maximum_12/y*
_output_shapes
: *
T0
O
floordiv_13/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_13FloorDivsub_21floordiv_13/y*
_output_shapes
: *
T0
N
Maximum_13/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_13Maximumfloordiv_13Maximum_13/y*
_output_shapes
: *
T0
J
sub_22/xConst*
_output_shapes
: *
dtype0*
value	B :P
D
sub_22Subsub_22/x
unstack_12*
T0*
_output_shapes
: 
5
Neg_7Negsub_22*
_output_shapes
: *
T0
O
floordiv_14/yConst*
_output_shapes
: *
dtype0*
value	B :
N
floordiv_14FloorDivNeg_7floordiv_14/y*
T0*
_output_shapes
: 
N
Maximum_14/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_14Maximumfloordiv_14Maximum_14/y*
_output_shapes
: *
T0
O
floordiv_15/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_15FloorDivsub_22floordiv_15/y*
T0*
_output_shapes
: 
N
Maximum_15/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_15Maximumfloordiv_15Maximum_15/y*
_output_shapes
: *
T0
M
Minimum_6/xConst*
value	B :P*
_output_shapes
: *
dtype0
N
	Minimum_6MinimumMinimum_6/x
unstack_12*
T0*
_output_shapes
: 
N
Minimum_7/xConst*
_output_shapes
: *
dtype0*
value
B :
P
	Minimum_7MinimumMinimum_7/xunstack_12:1*
_output_shapes
: *
T0
]
Shape_23Shapecontrol_dependency_12*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_10/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_10/assert_less/LessLessassert_positive_10/ConstShape_23*
_output_shapes
:*
T0
n
$assert_positive_10/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_10/assert_less/AllAll#assert_positive_10/assert_less/Less$assert_positive_10/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_10/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_10/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_10/assert_less/Assert/AssertAssert"assert_positive_10/assert_less/All3assert_positive_10/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_24Shapecontrol_dependency_12*
T0*
out_type0*
_output_shapes
:
Z

unstack_13UnpackShape_24*

axis *
_output_shapes
: : : *	
num*
T0
S
GreaterEqual_24/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_24GreaterEqual
Maximum_12GreaterEqual_24/y*
T0*
_output_shapes
: 
j
Assert_30/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_width must be >= 0.
r
Assert_30/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
a
Assert_30/AssertAssertGreaterEqual_24Assert_30/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_25/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_25GreaterEqual
Maximum_14GreaterEqual_25/y*
T0*
_output_shapes
: 
k
Assert_31/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_31/Assert/data_0Const*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
a
Assert_31/AssertAssertGreaterEqual_25Assert_31/Assert/data_0*
	summarize*

T
2
M
Greater_6/yConst*
value	B : *
dtype0*
_output_shapes
: 
M
	Greater_6Greater	Minimum_7Greater_6/y*
T0*
_output_shapes
: 
i
Assert_32/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
q
Assert_32/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
[
Assert_32/AssertAssert	Greater_6Assert_32/Assert/data_0*
	summarize*

T
2
M
Greater_7/yConst*
dtype0*
_output_shapes
: *
value	B : 
M
	Greater_7Greater	Minimum_6Greater_7/y*
T0*
_output_shapes
: 
j
Assert_33/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
r
Assert_33/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
[
Assert_33/AssertAssert	Greater_7Assert_33/Assert/data_0*

T
2*
	summarize
D
add_6Add	Minimum_7
Maximum_12*
_output_shapes
: *
T0
U
GreaterEqual_26GreaterEqualunstack_13:1add_6*
T0*
_output_shapes
: 
q
Assert_34/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
y
Assert_34/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
a
Assert_34/AssertAssertGreaterEqual_26Assert_34/Assert/data_0*

T
2*
	summarize
D
add_7Add	Minimum_6
Maximum_14*
_output_shapes
: *
T0
S
GreaterEqual_27GreaterEqual
unstack_13add_7*
T0*
_output_shapes
: 
r
Assert_35/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_35/Assert/data_0Const*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_35/AssertAssertGreaterEqual_27Assert_35/Assert/data_0*
	summarize*

T
2
Т
control_dependency_13Identitycontrol_dependency_12-^assert_positive_10/assert_less/Assert/Assert^Assert_30/Assert^Assert_31/Assert^Assert_32/Assert^Assert_33/Assert^Assert_34/Assert^Assert_35/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_3
K
	stack_9/2Const*
_output_shapes
: *
dtype0*
value	B : 
l
stack_9Pack
Maximum_14
Maximum_12	stack_9/2*
T0*

axis *
N*
_output_shapes
:
U

stack_10/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
l
stack_10Pack	Minimum_6	Minimum_7
stack_10/2*
T0*

axis *
N*
_output_shapes
:

Slice_3Slicecontrol_dependency_13stack_9stack_10*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_25ShapeSlice_3*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_11/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_11/assert_less/LessLessassert_positive_11/ConstShape_25*
T0*
_output_shapes
:
n
$assert_positive_11/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_11/assert_less/AllAll#assert_positive_11/assert_less/Less$assert_positive_11/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_11/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_11/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_11/assert_less/Assert/AssertAssert"assert_positive_11/assert_less/All3assert_positive_11/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_26ShapeSlice_3*
T0*
_output_shapes
:*
out_type0
Z

unstack_14UnpackShape_26*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_23/xConst*
value
B :*
dtype0*
_output_shapes
: 
D
sub_23Subsub_23/x
Maximum_13*
_output_shapes
: *
T0
D
sub_24Subsub_23unstack_14:1*
T0*
_output_shapes
: 
J
sub_25/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_25Subsub_25/x
Maximum_15*
_output_shapes
: *
T0
B
sub_26Subsub_25
unstack_14*
_output_shapes
: *
T0
S
GreaterEqual_28/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_28GreaterEqual
Maximum_15GreaterEqual_28/y*
T0*
_output_shapes
: 
j
Assert_36/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
r
Assert_36/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_36/AssertAssertGreaterEqual_28Assert_36/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_29/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_29GreaterEqual
Maximum_13GreaterEqual_29/y*
T0*
_output_shapes
: 
i
Assert_37/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_37/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
a
Assert_37/AssertAssertGreaterEqual_29Assert_37/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_30/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_30GreaterEqualsub_24GreaterEqual_30/y*
_output_shapes
: *
T0
p
Assert_38/ConstConst*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_38/Assert/data_0Const*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
a
Assert_38/AssertAssertGreaterEqual_30Assert_38/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_31/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_31GreaterEqualsub_26GreaterEqual_31/y*
_output_shapes
: *
T0
q
Assert_39/ConstConst*
_output_shapes
: *
dtype0*2
value)B' B!height must be <= target - offset
y
Assert_39/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_39/AssertAssertGreaterEqual_31Assert_39/Assert/data_0*
	summarize*

T
2

control_dependency_14IdentitySlice_3-^assert_positive_11/assert_less/Assert/Assert^Assert_36/Assert^Assert_37/Assert^Assert_38/Assert^Assert_39/Assert*
_class
loc:@Slice_3*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_11/4Const*
value	B : *
dtype0*
_output_shapes
: 
L

stack_11/5Const*
_output_shapes
: *
dtype0*
value	B : 

stack_11Pack
Maximum_15sub_26
Maximum_13sub_24
stack_11/4
stack_11/5*
N*
T0*
_output_shapes
:*

axis 
`
Reshape_6/shapeConst*
valueB"      *
_output_shapes
:*
dtype0
f
	Reshape_6Reshapestack_11Reshape_6/shape*
Tshape0*
_output_shapes

:*
T0
v
Pad_3Padcontrol_dependency_14	Reshape_6*,
_output_shapes
:Pџџџџџџџџџ*
	Tpaddings0*
T0
M
Shape_27ShapePad_3*
T0*
_output_shapes
:*
out_type0
Z

unstack_15UnpackShape_27*
_output_shapes
: : : *

axis *	
num*
T0
y
control_dependency_15IdentityPad_3*
T0*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad_3
d
Reshape_7/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
x
	Reshape_7Reshapecontrol_dependency_15Reshape_7/shape*
T0*#
_output_shapes
:P*
Tshape0
Y
	ToFloat_3Cast	Reshape_7*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_3/yConst*
valueB
 *  C*
dtype0*
_output_shapes
: 
R
div_3RealDiv	ToFloat_3div_3/y*
T0*#
_output_shapes
:P
M
sub_27/yConst*
valueB
 *   ?*
_output_shapes
: *
dtype0
L
sub_27Subdiv_3sub_27/y*
T0*#
_output_shapes
:P
v
shuffle_batch_3/ConstConst*
dtype0*
_output_shapes
:*-
value$B""      №?                
Y
shuffle_batch_3/Const_1Const*
value	B
 Z*
_output_shapes
: *
dtype0

ј
$shuffle_batch_3/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
shared_name *
seed2 *
	container *

seed *
capacity*
min_after_dequeue

z
shuffle_batch_3/cond/SwitchSwitchshuffle_batch_3/Const_1shuffle_batch_3/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_3/cond/switch_tIdentityshuffle_batch_3/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_3/cond/switch_fIdentityshuffle_batch_3/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_3/cond/pred_idIdentityshuffle_batch_3/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_3/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_3/random_shuffle_queueshuffle_batch_3/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_3/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_27shuffle_batch_3/cond/pred_id*
_class
loc:@sub_27*2
_output_shapes 
:P:P*
T0
Ю
:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_3/Constshuffle_batch_3/cond/pred_id*
T0*(
_class
loc:@shuffle_batch_3/Const* 
_output_shapes
::
­
1shuffle_batch_3/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_3/cond/control_dependencyIdentityshuffle_batch_3/cond/switch_t2^shuffle_batch_3/cond/random_shuffle_queue_enqueue*
T0
*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_3/cond/switch_t
A
shuffle_batch_3/cond/NoOpNoOp^shuffle_batch_3/cond/switch_f
У
)shuffle_batch_3/cond/control_dependency_1Identityshuffle_batch_3/cond/switch_f^shuffle_batch_3/cond/NoOp*
T0
*0
_class&
$"loc:@shuffle_batch_3/cond/switch_f*
_output_shapes
: 
Ѓ
shuffle_batch_3/cond/MergeMerge)shuffle_batch_3/cond/control_dependency_1'shuffle_batch_3/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_3/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_3/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_3/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_3/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_3/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_3/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_3/sub/yConst*
value	B :
*
dtype0*
_output_shapes
: 
}
shuffle_batch_3/subSub)shuffle_batch_3/random_shuffle_queue_Sizeshuffle_batch_3/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_3/Maximum/xConst*
value	B : *
dtype0*
_output_shapes
: 
s
shuffle_batch_3/MaximumMaximumshuffle_batch_3/Maximum/xshuffle_batch_3/sub*
_output_shapes
: *
T0
e
shuffle_batch_3/CastCastshuffle_batch_3/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_3/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *ЋЊЊ=
h
shuffle_batch_3/mulMulshuffle_batch_3/Castshuffle_batch_3/mul/y*
_output_shapes
: *
T0

0shuffle_batch_3/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_3/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_3/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_3/fraction_over_10_of_12_full/tagsshuffle_batch_3/mul*
T0*
_output_shapes
: 
S
shuffle_batch_3/nConst*
dtype0*
_output_shapes
: *
value	B :
Ч
shuffle_batch_3QueueDequeueManyV2$shuffle_batch_3/random_shuffle_queueshuffle_batch_3/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
x
*matching_filenames_4/MatchingFiles/patternConst*
valueB BValid/1/*.jpg*
_output_shapes
: *
dtype0

"matching_filenames_4/MatchingFilesMatchingFiles*matching_filenames_4/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_4
VariableV2*
shared_name *
dtype0*
shape:*
_output_shapes
:*
	container 
п
matching_filenames_4/AssignAssignmatching_filenames_4"matching_filenames_4/MatchingFiles*#
_output_shapes
:џџџџџџџџџ*
validate_shape( *'
_class
loc:@matching_filenames_4*
T0*
use_locking(

matching_filenames_4/readIdentitymatching_filenames_4*'
_class
loc:@matching_filenames_4*
_output_shapes
:*
T0
i
input_producer_4/SizeSizematching_filenames_4/read*
_output_shapes
: *
out_type0*
T0
\
input_producer_4/Greater/yConst*
dtype0*
_output_shapes
: *
value	B : 
w
input_producer_4/GreaterGreaterinput_producer_4/Sizeinput_producer_4/Greater/y*
_output_shapes
: *
T0

input_producer_4/Assert/ConstConst*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_4/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

input_producer_4/Assert/AssertAssertinput_producer_4/Greater%input_producer_4/Assert/Assert/data_0*
	summarize*

T
2

input_producer_4/IdentityIdentitymatching_filenames_4/read^input_producer_4/Assert/Assert*
_output_shapes
:*
T0

input_producer_4FIFOQueueV2*
shapes
: *
shared_name *
capacity *
_output_shapes
: *
component_types
2*
	container 
Ё
-input_producer_4/input_producer_4_EnqueueManyQueueEnqueueManyV2input_producer_4input_producer_4/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_4/input_producer_4_CloseQueueCloseV2input_producer_4*
cancel_pending_enqueues( 
j
)input_producer_4/input_producer_4_Close_1QueueCloseV2input_producer_4*
cancel_pending_enqueues(
_
&input_producer_4/input_producer_4_SizeQueueSizeV2input_producer_4*
_output_shapes
: 
u
input_producer_4/CastCast&input_producer_4/input_producer_4_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_4/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_4/mulMulinput_producer_4/Castinput_producer_4/mul/y*
T0*
_output_shapes
: 

)input_producer_4/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_4/fraction_of_32_full

$input_producer_4/fraction_of_32_fullScalarSummary)input_producer_4/fraction_of_32_full/tagsinput_producer_4/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_4WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_4ReaderReadV2WholeFileReaderV2_4input_producer_4*
_output_shapes
: : 
ь
DecodeJpeg_4
DecodeJpegReaderReadV2_4:1*
acceptable_fraction%  ?*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
channels *
try_recover_truncated( *

dct_method *
fancy_upscaling(
T
Shape_28ShapeDecodeJpeg_4*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_12/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_12/assert_less/LessLessassert_positive_12/ConstShape_28*
T0*
_output_shapes
:
n
$assert_positive_12/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_12/assert_less/AllAll#assert_positive_12/assert_less/Less$assert_positive_12/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_12/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_12/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_12/assert_less/Assert/AssertAssert"assert_positive_12/assert_less/All3assert_positive_12/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_16IdentityDecodeJpeg_4-^assert_positive_12/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
]
Shape_29Shapecontrol_dependency_16*
out_type0*
_output_shapes
:*
T0
Z

unstack_16UnpackShape_29*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_28/xConst*
_output_shapes
: *
dtype0*
value
B :
F
sub_28Subsub_28/xunstack_16:1*
_output_shapes
: *
T0
5
Neg_8Negsub_28*
_output_shapes
: *
T0
O
floordiv_16/yConst*
dtype0*
_output_shapes
: *
value	B :
N
floordiv_16FloorDivNeg_8floordiv_16/y*
T0*
_output_shapes
: 
N
Maximum_16/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_16Maximumfloordiv_16Maximum_16/y*
T0*
_output_shapes
: 
O
floordiv_17/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_17FloorDivsub_28floordiv_17/y*
T0*
_output_shapes
: 
N
Maximum_17/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_17Maximumfloordiv_17Maximum_17/y*
T0*
_output_shapes
: 
J
sub_29/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_29Subsub_29/x
unstack_16*
T0*
_output_shapes
: 
5
Neg_9Negsub_29*
T0*
_output_shapes
: 
O
floordiv_18/yConst*
value	B :*
_output_shapes
: *
dtype0
N
floordiv_18FloorDivNeg_9floordiv_18/y*
_output_shapes
: *
T0
N
Maximum_18/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_18Maximumfloordiv_18Maximum_18/y*
T0*
_output_shapes
: 
O
floordiv_19/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_19FloorDivsub_29floordiv_19/y*
_output_shapes
: *
T0
N
Maximum_19/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_19Maximumfloordiv_19Maximum_19/y*
T0*
_output_shapes
: 
M
Minimum_8/xConst*
value	B :P*
_output_shapes
: *
dtype0
N
	Minimum_8MinimumMinimum_8/x
unstack_16*
T0*
_output_shapes
: 
N
Minimum_9/xConst*
_output_shapes
: *
dtype0*
value
B :
P
	Minimum_9MinimumMinimum_9/xunstack_16:1*
_output_shapes
: *
T0
]
Shape_30Shapecontrol_dependency_16*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_13/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_13/assert_less/LessLessassert_positive_13/ConstShape_30*
_output_shapes
:*
T0
n
$assert_positive_13/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_13/assert_less/AllAll#assert_positive_13/assert_less/Less$assert_positive_13/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_13/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_13/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_13/assert_less/Assert/AssertAssert"assert_positive_13/assert_less/All3assert_positive_13/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_31Shapecontrol_dependency_16*
_output_shapes
:*
out_type0*
T0
Z

unstack_17UnpackShape_31*

axis *
_output_shapes
: : : *	
num*
T0
S
GreaterEqual_32/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_32GreaterEqual
Maximum_16GreaterEqual_32/y*
_output_shapes
: *
T0
j
Assert_40/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_40/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_40/AssertAssertGreaterEqual_32Assert_40/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_33/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_33GreaterEqual
Maximum_18GreaterEqual_33/y*
_output_shapes
: *
T0
k
Assert_41/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_41/Assert/data_0Const*
dtype0*
_output_shapes
: *,
value#B! Boffset_height must be >= 0.
a
Assert_41/AssertAssertGreaterEqual_33Assert_41/Assert/data_0*
	summarize*

T
2
M
Greater_8/yConst*
value	B : *
_output_shapes
: *
dtype0
M
	Greater_8Greater	Minimum_9Greater_8/y*
_output_shapes
: *
T0
i
Assert_42/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_42/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
[
Assert_42/AssertAssert	Greater_8Assert_42/Assert/data_0*
	summarize*

T
2
M
Greater_9/yConst*
dtype0*
_output_shapes
: *
value	B : 
M
	Greater_9Greater	Minimum_8Greater_9/y*
T0*
_output_shapes
: 
j
Assert_43/ConstConst*+
value"B  Btarget_height must be > 0.*
dtype0*
_output_shapes
: 
r
Assert_43/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
[
Assert_43/AssertAssert	Greater_9Assert_43/Assert/data_0*
	summarize*

T
2
D
add_8Add	Minimum_9
Maximum_16*
_output_shapes
: *
T0
U
GreaterEqual_34GreaterEqualunstack_17:1add_8*
_output_shapes
: *
T0
q
Assert_44/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_44/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_44/AssertAssertGreaterEqual_34Assert_44/Assert/data_0*

T
2*
	summarize
D
add_9Add	Minimum_8
Maximum_18*
T0*
_output_shapes
: 
S
GreaterEqual_35GreaterEqual
unstack_17add_9*
_output_shapes
: *
T0
r
Assert_45/ConstConst*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
z
Assert_45/Assert/data_0Const*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
a
Assert_45/AssertAssertGreaterEqual_35Assert_45/Assert/data_0*
	summarize*

T
2
Т
control_dependency_17Identitycontrol_dependency_16-^assert_positive_13/assert_less/Assert/Assert^Assert_40/Assert^Assert_41/Assert^Assert_42/Assert^Assert_43/Assert^Assert_44/Assert^Assert_45/Assert*
T0*
_class
loc:@DecodeJpeg_4*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_12/2Const*
_output_shapes
: *
dtype0*
value	B : 
n
stack_12Pack
Maximum_18
Maximum_16
stack_12/2*
T0*

axis *
N*
_output_shapes
:
U

stack_13/2Const*
valueB :
џџџџџџџџџ*
dtype0*
_output_shapes
: 
l
stack_13Pack	Minimum_8	Minimum_9
stack_13/2*
T0*

axis *
N*
_output_shapes
:

Slice_4Slicecontrol_dependency_17stack_12stack_13*
Index0*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
O
Shape_32ShapeSlice_4*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_14/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_14/assert_less/LessLessassert_positive_14/ConstShape_32*
T0*
_output_shapes
:
n
$assert_positive_14/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_14/assert_less/AllAll#assert_positive_14/assert_less/Less$assert_positive_14/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_14/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_14/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Ќ
,assert_positive_14/assert_less/Assert/AssertAssert"assert_positive_14/assert_less/All3assert_positive_14/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_33ShapeSlice_4*
_output_shapes
:*
out_type0*
T0
Z

unstack_18UnpackShape_33*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_30/xConst*
value
B :*
dtype0*
_output_shapes
: 
D
sub_30Subsub_30/x
Maximum_17*
_output_shapes
: *
T0
D
sub_31Subsub_30unstack_18:1*
_output_shapes
: *
T0
J
sub_32/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_32Subsub_32/x
Maximum_19*
_output_shapes
: *
T0
B
sub_33Subsub_32
unstack_18*
_output_shapes
: *
T0
S
GreaterEqual_36/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_36GreaterEqual
Maximum_19GreaterEqual_36/y*
_output_shapes
: *
T0
j
Assert_46/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
r
Assert_46/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_46/AssertAssertGreaterEqual_36Assert_46/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_37/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_37GreaterEqual
Maximum_17GreaterEqual_37/y*
_output_shapes
: *
T0
i
Assert_47/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_47/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
a
Assert_47/AssertAssertGreaterEqual_37Assert_47/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_38/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_38GreaterEqualsub_31GreaterEqual_38/y*
_output_shapes
: *
T0
p
Assert_48/ConstConst*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
x
Assert_48/Assert/data_0Const*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
a
Assert_48/AssertAssertGreaterEqual_38Assert_48/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_39/yConst*
value	B : *
dtype0*
_output_shapes
: 
[
GreaterEqual_39GreaterEqualsub_33GreaterEqual_39/y*
T0*
_output_shapes
: 
q
Assert_49/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
y
Assert_49/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_49/AssertAssertGreaterEqual_39Assert_49/Assert/data_0*
	summarize*

T
2

control_dependency_18IdentitySlice_4-^assert_positive_14/assert_less/Assert/Assert^Assert_46/Assert^Assert_47/Assert^Assert_48/Assert^Assert_49/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_4*
T0
L

stack_14/4Const*
dtype0*
_output_shapes
: *
value	B : 
L

stack_14/5Const*
dtype0*
_output_shapes
: *
value	B : 

stack_14Pack
Maximum_19sub_33
Maximum_17sub_31
stack_14/4
stack_14/5*

axis *
_output_shapes
:*
T0*
N
`
Reshape_8/shapeConst*
valueB"      *
dtype0*
_output_shapes
:
f
	Reshape_8Reshapestack_14Reshape_8/shape*
Tshape0*
_output_shapes

:*
T0
v
Pad_4Padcontrol_dependency_18	Reshape_8*
	Tpaddings0*
T0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_34ShapePad_4*
_output_shapes
:*
out_type0*
T0
Z

unstack_19UnpackShape_34*	
num*
T0*
_output_shapes
: : : *

axis 
y
control_dependency_19IdentityPad_4*
T0*
_class

loc:@Pad_4*,
_output_shapes
:Pџџџџџџџџџ
d
Reshape_9/shapeConst*!
valueB"P         *
dtype0*
_output_shapes
:
x
	Reshape_9Reshapecontrol_dependency_19Reshape_9/shape*#
_output_shapes
:P*
Tshape0*
T0
Y
	ToFloat_4Cast	Reshape_9*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_4/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
R
div_4RealDiv	ToFloat_4div_4/y*
T0*#
_output_shapes
:P
M
sub_34/yConst*
_output_shapes
: *
dtype0*
valueB
 *   ?
L
sub_34Subdiv_4sub_34/y*
T0*#
_output_shapes
:P
v
shuffle_batch_4/ConstConst*
dtype0*
_output_shapes
:*-
value$B""              №?        
Y
shuffle_batch_4/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_4/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
	container *
seed2 *
min_after_dequeue
*
capacity*
shared_name *

seed 
z
shuffle_batch_4/cond/SwitchSwitchshuffle_batch_4/Const_1shuffle_batch_4/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_4/cond/switch_tIdentityshuffle_batch_4/cond/Switch:1*
_output_shapes
: *
T0

g
shuffle_batch_4/cond/switch_fIdentityshuffle_batch_4/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_4/cond/pred_idIdentityshuffle_batch_4/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_4/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_4/random_shuffle_queueshuffle_batch_4/cond/pred_id*7
_class-
+)loc:@shuffle_batch_4/random_shuffle_queue*
_output_shapes
: : *
T0
Т
:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_34shuffle_batch_4/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_34
Ю
:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_4/Constshuffle_batch_4/cond/pred_id*(
_class
loc:@shuffle_batch_4/Const* 
_output_shapes
::*
T0
­
1shuffle_batch_4/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_4/cond/control_dependencyIdentityshuffle_batch_4/cond/switch_t2^shuffle_batch_4/cond/random_shuffle_queue_enqueue*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_4/cond/switch_t*
T0

A
shuffle_batch_4/cond/NoOpNoOp^shuffle_batch_4/cond/switch_f
У
)shuffle_batch_4/cond/control_dependency_1Identityshuffle_batch_4/cond/switch_f^shuffle_batch_4/cond/NoOp*
_output_shapes
: *0
_class&
$"loc:@shuffle_batch_4/cond/switch_f*
T0

Ѓ
shuffle_batch_4/cond/MergeMerge)shuffle_batch_4/cond/control_dependency_1'shuffle_batch_4/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_4/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_4/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_4/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_4/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_4/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_4/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_4/sub/yConst*
dtype0*
_output_shapes
: *
value	B :

}
shuffle_batch_4/subSub)shuffle_batch_4/random_shuffle_queue_Sizeshuffle_batch_4/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_4/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
s
shuffle_batch_4/MaximumMaximumshuffle_batch_4/Maximum/xshuffle_batch_4/sub*
T0*
_output_shapes
: 
e
shuffle_batch_4/CastCastshuffle_batch_4/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_4/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_4/mulMulshuffle_batch_4/Castshuffle_batch_4/mul/y*
_output_shapes
: *
T0

0shuffle_batch_4/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_4/fraction_over_10_of_12_full*
_output_shapes
: *
dtype0
Є
+shuffle_batch_4/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_4/fraction_over_10_of_12_full/tagsshuffle_batch_4/mul*
_output_shapes
: *
T0
S
shuffle_batch_4/nConst*
value	B :*
dtype0*
_output_shapes
: 
Ч
shuffle_batch_4QueueDequeueManyV2$shuffle_batch_4/random_shuffle_queueshuffle_batch_4/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
x
*matching_filenames_5/MatchingFiles/patternConst*
_output_shapes
: *
dtype0*
valueB BValid/2/*.jpg

"matching_filenames_5/MatchingFilesMatchingFiles*matching_filenames_5/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_5
VariableV2*
_output_shapes
:*
	container *
dtype0*
shared_name *
shape:
п
matching_filenames_5/AssignAssignmatching_filenames_5"matching_filenames_5/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_5

matching_filenames_5/readIdentitymatching_filenames_5*'
_class
loc:@matching_filenames_5*
_output_shapes
:*
T0
i
input_producer_5/SizeSizematching_filenames_5/read*
_output_shapes
: *
out_type0*
T0
\
input_producer_5/Greater/yConst*
value	B : *
_output_shapes
: *
dtype0
w
input_producer_5/GreaterGreaterinput_producer_5/Sizeinput_producer_5/Greater/y*
_output_shapes
: *
T0

input_producer_5/Assert/ConstConst*
dtype0*
_output_shapes
: *G
value>B< B6string_input_producer requires a non-null input tensor

%input_producer_5/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_5/Assert/AssertAssertinput_producer_5/Greater%input_producer_5/Assert/Assert/data_0*

T
2*
	summarize

input_producer_5/IdentityIdentitymatching_filenames_5/read^input_producer_5/Assert/Assert*
_output_shapes
:*
T0

input_producer_5FIFOQueueV2*
shapes
: *
shared_name *
capacity *
	container *
_output_shapes
: *
component_types
2
Ё
-input_producer_5/input_producer_5_EnqueueManyQueueEnqueueManyV2input_producer_5input_producer_5/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_5/input_producer_5_CloseQueueCloseV2input_producer_5*
cancel_pending_enqueues( 
j
)input_producer_5/input_producer_5_Close_1QueueCloseV2input_producer_5*
cancel_pending_enqueues(
_
&input_producer_5/input_producer_5_SizeQueueSizeV2input_producer_5*
_output_shapes
: 
u
input_producer_5/CastCast&input_producer_5/input_producer_5_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_5/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_5/mulMulinput_producer_5/Castinput_producer_5/mul/y*
_output_shapes
: *
T0

)input_producer_5/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_5/fraction_of_32_full

$input_producer_5/fraction_of_32_fullScalarSummary)input_producer_5/fraction_of_32_full/tagsinput_producer_5/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_5WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_5ReaderReadV2WholeFileReaderV2_5input_producer_5*
_output_shapes
: : 
ь
DecodeJpeg_5
DecodeJpegReaderReadV2_5:1*
acceptable_fraction%  ?*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
channels *
try_recover_truncated( *

dct_method *
fancy_upscaling(
T
Shape_35ShapeDecodeJpeg_5*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_15/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_15/assert_less/LessLessassert_positive_15/ConstShape_35*
_output_shapes
:*
T0
n
$assert_positive_15/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_15/assert_less/AllAll#assert_positive_15/assert_less/Less$assert_positive_15/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_15/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_15/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0
Ќ
,assert_positive_15/assert_less/Assert/AssertAssert"assert_positive_15/assert_less/All3assert_positive_15/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Ч
control_dependency_20IdentityDecodeJpeg_5-^assert_positive_15/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg_5*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
]
Shape_36Shapecontrol_dependency_20*
T0*
out_type0*
_output_shapes
:
Z

unstack_20UnpackShape_36*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_35/xConst*
value
B :*
_output_shapes
: *
dtype0
F
sub_35Subsub_35/xunstack_20:1*
T0*
_output_shapes
: 
6
Neg_10Negsub_35*
_output_shapes
: *
T0
O
floordiv_20/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_20FloorDivNeg_10floordiv_20/y*
_output_shapes
: *
T0
N
Maximum_20/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_20Maximumfloordiv_20Maximum_20/y*
T0*
_output_shapes
: 
O
floordiv_21/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_21FloorDivsub_35floordiv_21/y*
T0*
_output_shapes
: 
N
Maximum_21/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_21Maximumfloordiv_21Maximum_21/y*
_output_shapes
: *
T0
J
sub_36/xConst*
value	B :P*
_output_shapes
: *
dtype0
D
sub_36Subsub_36/x
unstack_20*
_output_shapes
: *
T0
6
Neg_11Negsub_36*
T0*
_output_shapes
: 
O
floordiv_22/yConst*
_output_shapes
: *
dtype0*
value	B :
O
floordiv_22FloorDivNeg_11floordiv_22/y*
_output_shapes
: *
T0
N
Maximum_22/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_22Maximumfloordiv_22Maximum_22/y*
T0*
_output_shapes
: 
O
floordiv_23/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_23FloorDivsub_36floordiv_23/y*
_output_shapes
: *
T0
N
Maximum_23/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_23Maximumfloordiv_23Maximum_23/y*
_output_shapes
: *
T0
N
Minimum_10/xConst*
_output_shapes
: *
dtype0*
value	B :P
P

Minimum_10MinimumMinimum_10/x
unstack_20*
_output_shapes
: *
T0
O
Minimum_11/xConst*
value
B :*
dtype0*
_output_shapes
: 
R

Minimum_11MinimumMinimum_11/xunstack_20:1*
T0*
_output_shapes
: 
]
Shape_37Shapecontrol_dependency_20*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_16/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_16/assert_less/LessLessassert_positive_16/ConstShape_37*
_output_shapes
:*
T0
n
$assert_positive_16/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_16/assert_less/AllAll#assert_positive_16/assert_less/Less$assert_positive_16/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_16/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_16/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_16/assert_less/Assert/AssertAssert"assert_positive_16/assert_less/All3assert_positive_16/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_38Shapecontrol_dependency_20*
_output_shapes
:*
out_type0*
T0
Z

unstack_21UnpackShape_38*	
num*
T0*
_output_shapes
: : : *

axis 
S
GreaterEqual_40/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_40GreaterEqual
Maximum_20GreaterEqual_40/y*
T0*
_output_shapes
: 
j
Assert_50/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
r
Assert_50/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_50/AssertAssertGreaterEqual_40Assert_50/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_41/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_41GreaterEqual
Maximum_22GreaterEqual_41/y*
_output_shapes
: *
T0
k
Assert_51/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_51/Assert/data_0Const*
dtype0*
_output_shapes
: *,
value#B! Boffset_height must be >= 0.
a
Assert_51/AssertAssertGreaterEqual_41Assert_51/Assert/data_0*
	summarize*

T
2
N
Greater_10/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_10Greater
Minimum_11Greater_10/y*
T0*
_output_shapes
: 
i
Assert_52/ConstConst*
_output_shapes
: *
dtype0**
value!B Btarget_width must be > 0.
q
Assert_52/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
\
Assert_52/AssertAssert
Greater_10Assert_52/Assert/data_0*
	summarize*

T
2
N
Greater_11/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_11Greater
Minimum_10Greater_11/y*
T0*
_output_shapes
: 
j
Assert_53/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_53/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
\
Assert_53/AssertAssert
Greater_11Assert_53/Assert/data_0*

T
2*
	summarize
F
add_10Add
Minimum_11
Maximum_20*
_output_shapes
: *
T0
V
GreaterEqual_42GreaterEqualunstack_21:1add_10*
T0*
_output_shapes
: 
q
Assert_54/ConstConst*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
y
Assert_54/Assert/data_0Const*
_output_shapes
: *
dtype0*2
value)B' B!width must be >= target + offset.
a
Assert_54/AssertAssertGreaterEqual_42Assert_54/Assert/data_0*
	summarize*

T
2
F
add_11Add
Minimum_10
Maximum_22*
_output_shapes
: *
T0
T
GreaterEqual_43GreaterEqual
unstack_21add_11*
_output_shapes
: *
T0
r
Assert_55/ConstConst*3
value*B( B"height must be >= target + offset.*
dtype0*
_output_shapes
: 
z
Assert_55/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_55/AssertAssertGreaterEqual_43Assert_55/Assert/data_0*

T
2*
	summarize
Т
control_dependency_21Identitycontrol_dependency_20-^assert_positive_16/assert_less/Assert/Assert^Assert_50/Assert^Assert_51/Assert^Assert_52/Assert^Assert_53/Assert^Assert_54/Assert^Assert_55/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_5
L

stack_15/2Const*
_output_shapes
: *
dtype0*
value	B : 
n
stack_15Pack
Maximum_22
Maximum_20
stack_15/2*
T0*

axis *
N*
_output_shapes
:
U

stack_16/2Const*
_output_shapes
: *
dtype0*
valueB :
џџџџџџџџџ
n
stack_16Pack
Minimum_10
Minimum_11
stack_16/2*
N*
T0*
_output_shapes
:*

axis 

Slice_5Slicecontrol_dependency_21stack_15stack_16*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_39ShapeSlice_5*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_17/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_17/assert_less/LessLessassert_positive_17/ConstShape_39*
T0*
_output_shapes
:
n
$assert_positive_17/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_17/assert_less/AllAll#assert_positive_17/assert_less/Less$assert_positive_17/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_17/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_17/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_17/assert_less/Assert/AssertAssert"assert_positive_17/assert_less/All3assert_positive_17/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_40ShapeSlice_5*
T0*
out_type0*
_output_shapes
:
Z

unstack_22UnpackShape_40*	
num*
T0*

axis *
_output_shapes
: : : 
K
sub_37/xConst*
value
B :*
_output_shapes
: *
dtype0
D
sub_37Subsub_37/x
Maximum_21*
T0*
_output_shapes
: 
D
sub_38Subsub_37unstack_22:1*
T0*
_output_shapes
: 
J
sub_39/xConst*
dtype0*
_output_shapes
: *
value	B :P
D
sub_39Subsub_39/x
Maximum_23*
_output_shapes
: *
T0
B
sub_40Subsub_39
unstack_22*
_output_shapes
: *
T0
S
GreaterEqual_44/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_44GreaterEqual
Maximum_23GreaterEqual_44/y*
T0*
_output_shapes
: 
j
Assert_56/ConstConst*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
r
Assert_56/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
a
Assert_56/AssertAssertGreaterEqual_44Assert_56/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_45/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_45GreaterEqual
Maximum_21GreaterEqual_45/y*
_output_shapes
: *
T0
i
Assert_57/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_57/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
a
Assert_57/AssertAssertGreaterEqual_45Assert_57/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_46/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_46GreaterEqualsub_38GreaterEqual_46/y*
_output_shapes
: *
T0
p
Assert_58/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
x
Assert_58/Assert/data_0Const*1
value(B& B width must be <= target - offset*
dtype0*
_output_shapes
: 
a
Assert_58/AssertAssertGreaterEqual_46Assert_58/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_47/yConst*
value	B : *
_output_shapes
: *
dtype0
[
GreaterEqual_47GreaterEqualsub_40GreaterEqual_47/y*
T0*
_output_shapes
: 
q
Assert_59/ConstConst*2
value)B' B!height must be <= target - offset*
dtype0*
_output_shapes
: 
y
Assert_59/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_59/AssertAssertGreaterEqual_47Assert_59/Assert/data_0*
	summarize*

T
2

control_dependency_22IdentitySlice_5-^assert_positive_17/assert_less/Assert/Assert^Assert_56/Assert^Assert_57/Assert^Assert_58/Assert^Assert_59/Assert*
T0*
_class
loc:@Slice_5*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
L

stack_17/4Const*
value	B : *
dtype0*
_output_shapes
: 
L

stack_17/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_17Pack
Maximum_23sub_40
Maximum_21sub_38
stack_17/4
stack_17/5*
T0*

axis *
N*
_output_shapes
:
a
Reshape_10/shapeConst*
dtype0*
_output_shapes
:*
valueB"      
h

Reshape_10Reshapestack_17Reshape_10/shape*
_output_shapes

:*
Tshape0*
T0
w
Pad_5Padcontrol_dependency_22
Reshape_10*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_41ShapePad_5*
_output_shapes
:*
out_type0*
T0
Z

unstack_23UnpackShape_41*	
num*
T0*

axis *
_output_shapes
: : : 
y
control_dependency_23IdentityPad_5*
T0*
_class

loc:@Pad_5*,
_output_shapes
:Pџџџџџџџџџ
e
Reshape_11/shapeConst*!
valueB"P         *
dtype0*
_output_shapes
:
z

Reshape_11Reshapecontrol_dependency_23Reshape_11/shape*
T0*
Tshape0*#
_output_shapes
:P
Z
	ToFloat_5Cast
Reshape_11*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_5/yConst*
dtype0*
_output_shapes
: *
valueB
 *  C
R
div_5RealDiv	ToFloat_5div_5/y*
T0*#
_output_shapes
:P
M
sub_41/yConst*
_output_shapes
: *
dtype0*
valueB
 *   ?
L
sub_41Subdiv_5sub_41/y*#
_output_shapes
:P*
T0
v
shuffle_batch_5/ConstConst*-
value$B""                      №?*
_output_shapes
:*
dtype0
Y
shuffle_batch_5/Const_1Const*
value	B
 Z*
_output_shapes
: *
dtype0

ј
$shuffle_batch_5/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
shared_name *
capacity*
min_after_dequeue
*
_output_shapes
: *
component_types
2*

seed *
seed2 *
	container 
z
shuffle_batch_5/cond/SwitchSwitchshuffle_batch_5/Const_1shuffle_batch_5/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_5/cond/switch_tIdentityshuffle_batch_5/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_5/cond/switch_fIdentityshuffle_batch_5/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_5/cond/pred_idIdentityshuffle_batch_5/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_5/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_5/random_shuffle_queueshuffle_batch_5/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_5/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_41shuffle_batch_5/cond/pred_id*
T0*
_class
loc:@sub_41*2
_output_shapes 
:P:P
Ю
:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_5/Constshuffle_batch_5/cond/pred_id*
T0*(
_class
loc:@shuffle_batch_5/Const* 
_output_shapes
::
­
1shuffle_batch_5/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_5/cond/control_dependencyIdentityshuffle_batch_5/cond/switch_t2^shuffle_batch_5/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_5/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_5/cond/NoOpNoOp^shuffle_batch_5/cond/switch_f
У
)shuffle_batch_5/cond/control_dependency_1Identityshuffle_batch_5/cond/switch_f^shuffle_batch_5/cond/NoOp*0
_class&
$"loc:@shuffle_batch_5/cond/switch_f*
_output_shapes
: *
T0

Ѓ
shuffle_batch_5/cond/MergeMerge)shuffle_batch_5/cond/control_dependency_1'shuffle_batch_5/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_5/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_5/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_5/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_5/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_5/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_5/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_5/sub/yConst*
dtype0*
_output_shapes
: *
value	B :

}
shuffle_batch_5/subSub)shuffle_batch_5/random_shuffle_queue_Sizeshuffle_batch_5/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_5/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_5/MaximumMaximumshuffle_batch_5/Maximum/xshuffle_batch_5/sub*
T0*
_output_shapes
: 
e
shuffle_batch_5/CastCastshuffle_batch_5/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_5/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_5/mulMulshuffle_batch_5/Castshuffle_batch_5/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_5/fraction_over_10_of_12_full/tagsConst*
_output_shapes
: *
dtype0*<
value3B1 B+shuffle_batch_5/fraction_over_10_of_12_full
Є
+shuffle_batch_5/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_5/fraction_over_10_of_12_full/tagsshuffle_batch_5/mul*
_output_shapes
: *
T0
S
shuffle_batch_5/nConst*
_output_shapes
: *
dtype0*
value	B :
Ч
shuffle_batch_5QueueDequeueManyV2$shuffle_batch_5/random_shuffle_queueshuffle_batch_5/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
O
concat_2/axisConst*
value	B : *
dtype0*
_output_shapes
: 

concat_2ConcatV2shuffle_batch_3shuffle_batch_4shuffle_batch_5concat_2/axis*'
_output_shapes
:P*
T0*

Tidx0*
N
O
concat_3/axisConst*
value	B : *
dtype0*
_output_shapes
: 

concat_3ConcatV2shuffle_batch_3:1shuffle_batch_4:1shuffle_batch_5:1concat_3/axis*
_output_shapes

:*
N*
T0*

Tidx0
w
*matching_filenames_6/MatchingFiles/patternConst*
dtype0*
_output_shapes
: *
valueB BTest/0/*.jpg

"matching_filenames_6/MatchingFilesMatchingFiles*matching_filenames_6/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_6
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_6/AssignAssignmatching_filenames_6"matching_filenames_6/MatchingFiles*#
_output_shapes
:џџџџџџџџџ*
validate_shape( *'
_class
loc:@matching_filenames_6*
T0*
use_locking(

matching_filenames_6/readIdentitymatching_filenames_6*'
_class
loc:@matching_filenames_6*
_output_shapes
:*
T0
i
input_producer_6/SizeSizematching_filenames_6/read*
T0*
out_type0*
_output_shapes
: 
\
input_producer_6/Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
w
input_producer_6/GreaterGreaterinput_producer_6/Sizeinput_producer_6/Greater/y*
T0*
_output_shapes
: 

input_producer_6/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

%input_producer_6/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_6/Assert/AssertAssertinput_producer_6/Greater%input_producer_6/Assert/Assert/data_0*
	summarize*

T
2

input_producer_6/IdentityIdentitymatching_filenames_6/read^input_producer_6/Assert/Assert*
T0*
_output_shapes
:

input_producer_6FIFOQueueV2*
shapes
: *
shared_name *
capacity *
_output_shapes
: *
component_types
2*
	container 
Ё
-input_producer_6/input_producer_6_EnqueueManyQueueEnqueueManyV2input_producer_6input_producer_6/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_6/input_producer_6_CloseQueueCloseV2input_producer_6*
cancel_pending_enqueues( 
j
)input_producer_6/input_producer_6_Close_1QueueCloseV2input_producer_6*
cancel_pending_enqueues(
_
&input_producer_6/input_producer_6_SizeQueueSizeV2input_producer_6*
_output_shapes
: 
u
input_producer_6/CastCast&input_producer_6/input_producer_6_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_6/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *   =
k
input_producer_6/mulMulinput_producer_6/Castinput_producer_6/mul/y*
T0*
_output_shapes
: 

)input_producer_6/fraction_of_32_full/tagsConst*5
value,B* B$input_producer_6/fraction_of_32_full*
_output_shapes
: *
dtype0

$input_producer_6/fraction_of_32_fullScalarSummary)input_producer_6/fraction_of_32_full/tagsinput_producer_6/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_6WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_6ReaderReadV2WholeFileReaderV2_6input_producer_6*
_output_shapes
: : 
ь
DecodeJpeg_6
DecodeJpegReaderReadV2_6:1*

dct_method *
channels *
acceptable_fraction%  ?*
fancy_upscaling(*
try_recover_truncated( *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio
T
Shape_42ShapeDecodeJpeg_6*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_18/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_18/assert_less/LessLessassert_positive_18/ConstShape_42*
_output_shapes
:*
T0
n
$assert_positive_18/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_18/assert_less/AllAll#assert_positive_18/assert_less/Less$assert_positive_18/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_18/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_18/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_18/assert_less/Assert/AssertAssert"assert_positive_18/assert_less/All3assert_positive_18/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_24IdentityDecodeJpeg_6-^assert_positive_18/assert_less/Assert/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_6*
T0
]
Shape_43Shapecontrol_dependency_24*
T0*
_output_shapes
:*
out_type0
Z

unstack_24UnpackShape_43*	
num*
T0*
_output_shapes
: : : *

axis 
K
sub_42/xConst*
dtype0*
_output_shapes
: *
value
B :
F
sub_42Subsub_42/xunstack_24:1*
T0*
_output_shapes
: 
6
Neg_12Negsub_42*
T0*
_output_shapes
: 
O
floordiv_24/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_24FloorDivNeg_12floordiv_24/y*
T0*
_output_shapes
: 
N
Maximum_24/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_24Maximumfloordiv_24Maximum_24/y*
T0*
_output_shapes
: 
O
floordiv_25/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_25FloorDivsub_42floordiv_25/y*
_output_shapes
: *
T0
N
Maximum_25/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_25Maximumfloordiv_25Maximum_25/y*
_output_shapes
: *
T0
J
sub_43/xConst*
_output_shapes
: *
dtype0*
value	B :P
D
sub_43Subsub_43/x
unstack_24*
T0*
_output_shapes
: 
6
Neg_13Negsub_43*
_output_shapes
: *
T0
O
floordiv_26/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_26FloorDivNeg_13floordiv_26/y*
_output_shapes
: *
T0
N
Maximum_26/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_26Maximumfloordiv_26Maximum_26/y*
_output_shapes
: *
T0
O
floordiv_27/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_27FloorDivsub_43floordiv_27/y*
T0*
_output_shapes
: 
N
Maximum_27/yConst*
value	B : *
dtype0*
_output_shapes
: 
Q

Maximum_27Maximumfloordiv_27Maximum_27/y*
T0*
_output_shapes
: 
N
Minimum_12/xConst*
dtype0*
_output_shapes
: *
value	B :P
P

Minimum_12MinimumMinimum_12/x
unstack_24*
_output_shapes
: *
T0
O
Minimum_13/xConst*
value
B :*
dtype0*
_output_shapes
: 
R

Minimum_13MinimumMinimum_13/xunstack_24:1*
_output_shapes
: *
T0
]
Shape_44Shapecontrol_dependency_24*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_19/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_19/assert_less/LessLessassert_positive_19/ConstShape_44*
T0*
_output_shapes
:
n
$assert_positive_19/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_19/assert_less/AllAll#assert_positive_19/assert_less/Less$assert_positive_19/assert_less/Const*
_output_shapes
: *

Tidx0*
	keep_dims( 

+assert_positive_19/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_19/assert_less/Assert/Assert/data_0Const*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_19/assert_less/Assert/AssertAssert"assert_positive_19/assert_less/All3assert_positive_19/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_45Shapecontrol_dependency_24*
T0*
_output_shapes
:*
out_type0
Z

unstack_25UnpackShape_45*	
num*
T0*

axis *
_output_shapes
: : : 
S
GreaterEqual_48/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_48GreaterEqual
Maximum_24GreaterEqual_48/y*
_output_shapes
: *
T0
j
Assert_60/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
r
Assert_60/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
a
Assert_60/AssertAssertGreaterEqual_48Assert_60/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_49/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_49GreaterEqual
Maximum_26GreaterEqual_49/y*
_output_shapes
: *
T0
k
Assert_61/ConstConst*
_output_shapes
: *
dtype0*,
value#B! Boffset_height must be >= 0.
s
Assert_61/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
a
Assert_61/AssertAssertGreaterEqual_49Assert_61/Assert/data_0*

T
2*
	summarize
N
Greater_12/yConst*
dtype0*
_output_shapes
: *
value	B : 
P

Greater_12Greater
Minimum_13Greater_12/y*
_output_shapes
: *
T0
i
Assert_62/ConstConst*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
q
Assert_62/Assert/data_0Const**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
\
Assert_62/AssertAssert
Greater_12Assert_62/Assert/data_0*

T
2*
	summarize
N
Greater_13/yConst*
dtype0*
_output_shapes
: *
value	B : 
P

Greater_13Greater
Minimum_12Greater_13/y*
T0*
_output_shapes
: 
j
Assert_63/ConstConst*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
r
Assert_63/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Btarget_height must be > 0.
\
Assert_63/AssertAssert
Greater_13Assert_63/Assert/data_0*
	summarize*

T
2
F
add_12Add
Minimum_13
Maximum_24*
T0*
_output_shapes
: 
V
GreaterEqual_50GreaterEqualunstack_25:1add_12*
T0*
_output_shapes
: 
q
Assert_64/ConstConst*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
y
Assert_64/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_64/AssertAssertGreaterEqual_50Assert_64/Assert/data_0*
	summarize*

T
2
F
add_13Add
Minimum_12
Maximum_26*
_output_shapes
: *
T0
T
GreaterEqual_51GreaterEqual
unstack_25add_13*
_output_shapes
: *
T0
r
Assert_65/ConstConst*3
value*B( B"height must be >= target + offset.*
_output_shapes
: *
dtype0
z
Assert_65/Assert/data_0Const*3
value*B( B"height must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_65/AssertAssertGreaterEqual_51Assert_65/Assert/data_0*

T
2*
	summarize
Т
control_dependency_25Identitycontrol_dependency_24-^assert_positive_19/assert_less/Assert/Assert^Assert_60/Assert^Assert_61/Assert^Assert_62/Assert^Assert_63/Assert^Assert_64/Assert^Assert_65/Assert*
_class
loc:@DecodeJpeg_6*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
L

stack_18/2Const*
_output_shapes
: *
dtype0*
value	B : 
n
stack_18Pack
Maximum_26
Maximum_24
stack_18/2*
T0*

axis *
N*
_output_shapes
:
U

stack_19/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
n
stack_19Pack
Minimum_12
Minimum_13
stack_19/2*
T0*

axis *
N*
_output_shapes
:

Slice_6Slicecontrol_dependency_25stack_18stack_19*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_46ShapeSlice_6*
_output_shapes
:*
out_type0*
T0
Z
assert_positive_20/ConstConst*
dtype0*
_output_shapes
: *
value	B : 
t
#assert_positive_20/assert_less/LessLessassert_positive_20/ConstShape_46*
T0*
_output_shapes
:
n
$assert_positive_20/assert_less/ConstConst*
_output_shapes
:*
dtype0*
valueB: 
Љ
"assert_positive_20/assert_less/AllAll#assert_positive_20/assert_less/Less$assert_positive_20/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_20/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_20/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_20/assert_less/Assert/AssertAssert"assert_positive_20/assert_less/All3assert_positive_20/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_47ShapeSlice_6*
_output_shapes
:*
out_type0*
T0
Z

unstack_26UnpackShape_47*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_44/xConst*
_output_shapes
: *
dtype0*
value
B :
D
sub_44Subsub_44/x
Maximum_25*
T0*
_output_shapes
: 
D
sub_45Subsub_44unstack_26:1*
_output_shapes
: *
T0
J
sub_46/xConst*
value	B :P*
_output_shapes
: *
dtype0
D
sub_46Subsub_46/x
Maximum_27*
_output_shapes
: *
T0
B
sub_47Subsub_46
unstack_26*
T0*
_output_shapes
: 
S
GreaterEqual_52/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_52GreaterEqual
Maximum_27GreaterEqual_52/y*
T0*
_output_shapes
: 
j
Assert_66/ConstConst*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
r
Assert_66/Assert/data_0Const*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
a
Assert_66/AssertAssertGreaterEqual_52Assert_66/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_53/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_53GreaterEqual
Maximum_25GreaterEqual_53/y*
_output_shapes
: *
T0
i
Assert_67/ConstConst**
value!B Boffset_width must be >= 0*
_output_shapes
: *
dtype0
q
Assert_67/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
a
Assert_67/AssertAssertGreaterEqual_53Assert_67/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_54/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_54GreaterEqualsub_45GreaterEqual_54/y*
T0*
_output_shapes
: 
p
Assert_68/ConstConst*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
x
Assert_68/Assert/data_0Const*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_68/AssertAssertGreaterEqual_54Assert_68/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_55/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_55GreaterEqualsub_47GreaterEqual_55/y*
_output_shapes
: *
T0
q
Assert_69/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
y
Assert_69/Assert/data_0Const*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_69/AssertAssertGreaterEqual_55Assert_69/Assert/data_0*

T
2*
	summarize

control_dependency_26IdentitySlice_6-^assert_positive_20/assert_less/Assert/Assert^Assert_66/Assert^Assert_67/Assert^Assert_68/Assert^Assert_69/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_6*
T0
L

stack_20/4Const*
dtype0*
_output_shapes
: *
value	B : 
L

stack_20/5Const*
dtype0*
_output_shapes
: *
value	B : 

stack_20Pack
Maximum_27sub_47
Maximum_25sub_45
stack_20/4
stack_20/5*
N*
T0*
_output_shapes
:*

axis 
a
Reshape_12/shapeConst*
_output_shapes
:*
dtype0*
valueB"      
h

Reshape_12Reshapestack_20Reshape_12/shape*
T0*
Tshape0*
_output_shapes

:
w
Pad_6Padcontrol_dependency_26
Reshape_12*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_48ShapePad_6*
T0*
_output_shapes
:*
out_type0
Z

unstack_27UnpackShape_48*

axis *
_output_shapes
: : : *	
num*
T0
y
control_dependency_27IdentityPad_6*
_class

loc:@Pad_6*,
_output_shapes
:Pџџџџџџџџџ*
T0
e
Reshape_13/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
z

Reshape_13Reshapecontrol_dependency_27Reshape_13/shape*
Tshape0*#
_output_shapes
:P*
T0
Z
	ToFloat_6Cast
Reshape_13*

SrcT0*#
_output_shapes
:P*

DstT0
L
div_6/yConst*
_output_shapes
: *
dtype0*
valueB
 *  C
R
div_6RealDiv	ToFloat_6div_6/y*
T0*#
_output_shapes
:P
M
sub_48/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
L
sub_48Subdiv_6sub_48/y*
T0*#
_output_shapes
:P
v
shuffle_batch_6/ConstConst*-
value$B""      №?                *
_output_shapes
:*
dtype0
Y
shuffle_batch_6/Const_1Const*
value	B
 Z*
dtype0
*
_output_shapes
: 
ј
$shuffle_batch_6/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
shared_name *
	container *
seed2 *

seed *
min_after_dequeue
*
capacity
z
shuffle_batch_6/cond/SwitchSwitchshuffle_batch_6/Const_1shuffle_batch_6/Const_1*
_output_shapes
: : *
T0

i
shuffle_batch_6/cond/switch_tIdentityshuffle_batch_6/cond/Switch:1*
_output_shapes
: *
T0

g
shuffle_batch_6/cond/switch_fIdentityshuffle_batch_6/cond/Switch*
T0
*
_output_shapes
: 
b
shuffle_batch_6/cond/pred_idIdentityshuffle_batch_6/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_6/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_6/random_shuffle_queueshuffle_batch_6/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_6/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_48shuffle_batch_6/cond/pred_id*
T0*
_class
loc:@sub_48*2
_output_shapes 
:P:P
Ю
:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_6/Constshuffle_batch_6/cond/pred_id*
T0*(
_class
loc:@shuffle_batch_6/Const* 
_output_shapes
::
­
1shuffle_batch_6/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_6/cond/control_dependencyIdentityshuffle_batch_6/cond/switch_t2^shuffle_batch_6/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_6/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_6/cond/NoOpNoOp^shuffle_batch_6/cond/switch_f
У
)shuffle_batch_6/cond/control_dependency_1Identityshuffle_batch_6/cond/switch_f^shuffle_batch_6/cond/NoOp*
T0
*0
_class&
$"loc:@shuffle_batch_6/cond/switch_f*
_output_shapes
: 
Ѓ
shuffle_batch_6/cond/MergeMerge)shuffle_batch_6/cond/control_dependency_1'shuffle_batch_6/cond/control_dependency*
_output_shapes
: : *
N*
T0


*shuffle_batch_6/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_6/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_6/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_6/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_6/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_6/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_6/sub/yConst*
_output_shapes
: *
dtype0*
value	B :

}
shuffle_batch_6/subSub)shuffle_batch_6/random_shuffle_queue_Sizeshuffle_batch_6/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_6/Maximum/xConst*
_output_shapes
: *
dtype0*
value	B : 
s
shuffle_batch_6/MaximumMaximumshuffle_batch_6/Maximum/xshuffle_batch_6/sub*
_output_shapes
: *
T0
e
shuffle_batch_6/CastCastshuffle_batch_6/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_6/mul/yConst*
valueB
 *ЋЊЊ=*
dtype0*
_output_shapes
: 
h
shuffle_batch_6/mulMulshuffle_batch_6/Castshuffle_batch_6/mul/y*
_output_shapes
: *
T0

0shuffle_batch_6/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_6/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_6/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_6/fraction_over_10_of_12_full/tagsshuffle_batch_6/mul*
_output_shapes
: *
T0
S
shuffle_batch_6/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_6QueueDequeueManyV2$shuffle_batch_6/random_shuffle_queueshuffle_batch_6/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
w
*matching_filenames_7/MatchingFiles/patternConst*
_output_shapes
: *
dtype0*
valueB BTest/1/*.jpg

"matching_filenames_7/MatchingFilesMatchingFiles*matching_filenames_7/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_7
VariableV2*
_output_shapes
:*
	container *
shape:*
dtype0*
shared_name 
п
matching_filenames_7/AssignAssignmatching_filenames_7"matching_filenames_7/MatchingFiles*'
_class
loc:@matching_filenames_7*#
_output_shapes
:џџџџџџџџџ*
T0*
validate_shape( *
use_locking(

matching_filenames_7/readIdentitymatching_filenames_7*
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_7
i
input_producer_7/SizeSizematching_filenames_7/read*
T0*
_output_shapes
: *
out_type0
\
input_producer_7/Greater/yConst*
value	B : *
dtype0*
_output_shapes
: 
w
input_producer_7/GreaterGreaterinput_producer_7/Sizeinput_producer_7/Greater/y*
T0*
_output_shapes
: 

input_producer_7/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

%input_producer_7/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_7/Assert/AssertAssertinput_producer_7/Greater%input_producer_7/Assert/Assert/data_0*
	summarize*

T
2

input_producer_7/IdentityIdentitymatching_filenames_7/read^input_producer_7/Assert/Assert*
T0*
_output_shapes
:

input_producer_7FIFOQueueV2*
shapes
: *
	container *
_output_shapes
: *
component_types
2*
capacity *
shared_name 
Ё
-input_producer_7/input_producer_7_EnqueueManyQueueEnqueueManyV2input_producer_7input_producer_7/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_7/input_producer_7_CloseQueueCloseV2input_producer_7*
cancel_pending_enqueues( 
j
)input_producer_7/input_producer_7_Close_1QueueCloseV2input_producer_7*
cancel_pending_enqueues(
_
&input_producer_7/input_producer_7_SizeQueueSizeV2input_producer_7*
_output_shapes
: 
u
input_producer_7/CastCast&input_producer_7/input_producer_7_Size*

SrcT0*
_output_shapes
: *

DstT0
[
input_producer_7/mul/yConst*
valueB
 *   =*
dtype0*
_output_shapes
: 
k
input_producer_7/mulMulinput_producer_7/Castinput_producer_7/mul/y*
_output_shapes
: *
T0

)input_producer_7/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_7/fraction_of_32_full

$input_producer_7/fraction_of_32_fullScalarSummary)input_producer_7/fraction_of_32_full/tagsinput_producer_7/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_7WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_7ReaderReadV2WholeFileReaderV2_7input_producer_7*
_output_shapes
: : 
ь
DecodeJpeg_7
DecodeJpegReaderReadV2_7:1*
fancy_upscaling(*

dct_method *
try_recover_truncated( *
channels *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
acceptable_fraction%  ?
T
Shape_49ShapeDecodeJpeg_7*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_21/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_21/assert_less/LessLessassert_positive_21/ConstShape_49*
T0*
_output_shapes
:
n
$assert_positive_21/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_21/assert_less/AllAll#assert_positive_21/assert_less/Less$assert_positive_21/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_21/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 

3assert_positive_21/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_21/assert_less/Assert/AssertAssert"assert_positive_21/assert_less/All3assert_positive_21/assert_less/Assert/Assert/data_0*
	summarize*

T
2
Ч
control_dependency_28IdentityDecodeJpeg_7-^assert_positive_21/assert_less/Assert/Assert*
T0*
_class
loc:@DecodeJpeg_7*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
]
Shape_50Shapecontrol_dependency_28*
out_type0*
_output_shapes
:*
T0
Z

unstack_28UnpackShape_50*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_49/xConst*
value
B :*
dtype0*
_output_shapes
: 
F
sub_49Subsub_49/xunstack_28:1*
_output_shapes
: *
T0
6
Neg_14Negsub_49*
_output_shapes
: *
T0
O
floordiv_28/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_28FloorDivNeg_14floordiv_28/y*
T0*
_output_shapes
: 
N
Maximum_28/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_28Maximumfloordiv_28Maximum_28/y*
T0*
_output_shapes
: 
O
floordiv_29/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_29FloorDivsub_49floordiv_29/y*
_output_shapes
: *
T0
N
Maximum_29/yConst*
dtype0*
_output_shapes
: *
value	B : 
Q

Maximum_29Maximumfloordiv_29Maximum_29/y*
_output_shapes
: *
T0
J
sub_50/xConst*
value	B :P*
_output_shapes
: *
dtype0
D
sub_50Subsub_50/x
unstack_28*
T0*
_output_shapes
: 
6
Neg_15Negsub_50*
T0*
_output_shapes
: 
O
floordiv_30/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_30FloorDivNeg_15floordiv_30/y*
T0*
_output_shapes
: 
N
Maximum_30/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_30Maximumfloordiv_30Maximum_30/y*
T0*
_output_shapes
: 
O
floordiv_31/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_31FloorDivsub_50floordiv_31/y*
_output_shapes
: *
T0
N
Maximum_31/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_31Maximumfloordiv_31Maximum_31/y*
T0*
_output_shapes
: 
N
Minimum_14/xConst*
_output_shapes
: *
dtype0*
value	B :P
P

Minimum_14MinimumMinimum_14/x
unstack_28*
T0*
_output_shapes
: 
O
Minimum_15/xConst*
_output_shapes
: *
dtype0*
value
B :
R

Minimum_15MinimumMinimum_15/xunstack_28:1*
T0*
_output_shapes
: 
]
Shape_51Shapecontrol_dependency_28*
T0*
_output_shapes
:*
out_type0
Z
assert_positive_22/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_22/assert_less/LessLessassert_positive_22/ConstShape_51*
T0*
_output_shapes
:
n
$assert_positive_22/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_22/assert_less/AllAll#assert_positive_22/assert_less/Less$assert_positive_22/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_22/assert_less/Assert/ConstConst*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_22/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_22/assert_less/Assert/AssertAssert"assert_positive_22/assert_less/All3assert_positive_22/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_52Shapecontrol_dependency_28*
_output_shapes
:*
out_type0*
T0
Z

unstack_29UnpackShape_52*
_output_shapes
: : : *

axis *	
num*
T0
S
GreaterEqual_56/yConst*
dtype0*
_output_shapes
: *
value	B : 
_
GreaterEqual_56GreaterEqual
Maximum_28GreaterEqual_56/y*
T0*
_output_shapes
: 
j
Assert_70/ConstConst*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
r
Assert_70/Assert/data_0Const*+
value"B  Boffset_width must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_70/AssertAssertGreaterEqual_56Assert_70/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_57/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_57GreaterEqual
Maximum_30GreaterEqual_57/y*
_output_shapes
: *
T0
k
Assert_71/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_71/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_71/AssertAssertGreaterEqual_57Assert_71/Assert/data_0*

T
2*
	summarize
N
Greater_14/yConst*
dtype0*
_output_shapes
: *
value	B : 
P

Greater_14Greater
Minimum_15Greater_14/y*
T0*
_output_shapes
: 
i
Assert_72/ConstConst**
value!B Btarget_width must be > 0.*
_output_shapes
: *
dtype0
q
Assert_72/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
\
Assert_72/AssertAssert
Greater_14Assert_72/Assert/data_0*

T
2*
	summarize
N
Greater_15/yConst*
_output_shapes
: *
dtype0*
value	B : 
P

Greater_15Greater
Minimum_14Greater_15/y*
_output_shapes
: *
T0
j
Assert_73/ConstConst*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
r
Assert_73/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Btarget_height must be > 0.
\
Assert_73/AssertAssert
Greater_15Assert_73/Assert/data_0*
	summarize*

T
2
F
add_14Add
Minimum_15
Maximum_28*
T0*
_output_shapes
: 
V
GreaterEqual_58GreaterEqualunstack_29:1add_14*
T0*
_output_shapes
: 
q
Assert_74/ConstConst*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
y
Assert_74/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
_output_shapes
: *
dtype0
a
Assert_74/AssertAssertGreaterEqual_58Assert_74/Assert/data_0*

T
2*
	summarize
F
add_15Add
Minimum_14
Maximum_30*
T0*
_output_shapes
: 
T
GreaterEqual_59GreaterEqual
unstack_29add_15*
T0*
_output_shapes
: 
r
Assert_75/ConstConst*
dtype0*
_output_shapes
: *3
value*B( B"height must be >= target + offset.
z
Assert_75/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_75/AssertAssertGreaterEqual_59Assert_75/Assert/data_0*

T
2*
	summarize
Т
control_dependency_29Identitycontrol_dependency_28-^assert_positive_22/assert_less/Assert/Assert^Assert_70/Assert^Assert_71/Assert^Assert_72/Assert^Assert_73/Assert^Assert_74/Assert^Assert_75/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_7
L

stack_21/2Const*
value	B : *
dtype0*
_output_shapes
: 
n
stack_21Pack
Maximum_30
Maximum_28
stack_21/2*
N*
T0*
_output_shapes
:*

axis 
U

stack_22/2Const*
_output_shapes
: *
dtype0*
valueB :
џџџџџџџџџ
n
stack_22Pack
Minimum_14
Minimum_15
stack_22/2*

axis *
_output_shapes
:*
T0*
N

Slice_7Slicecontrol_dependency_29stack_21stack_22*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
Index0*
T0
O
Shape_53ShapeSlice_7*
out_type0*
_output_shapes
:*
T0
Z
assert_positive_23/ConstConst*
_output_shapes
: *
dtype0*
value	B : 
t
#assert_positive_23/assert_less/LessLessassert_positive_23/ConstShape_53*
T0*
_output_shapes
:
n
$assert_positive_23/assert_less/ConstConst*
valueB: *
_output_shapes
:*
dtype0
Љ
"assert_positive_23/assert_less/AllAll#assert_positive_23/assert_less/Less$assert_positive_23/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_23/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_23/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_23/assert_less/Assert/AssertAssert"assert_positive_23/assert_less/All3assert_positive_23/assert_less/Assert/Assert/data_0*

T
2*
	summarize
O
Shape_54ShapeSlice_7*
T0*
out_type0*
_output_shapes
:
Z

unstack_30UnpackShape_54*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_51/xConst*
_output_shapes
: *
dtype0*
value
B :
D
sub_51Subsub_51/x
Maximum_29*
T0*
_output_shapes
: 
D
sub_52Subsub_51unstack_30:1*
T0*
_output_shapes
: 
J
sub_53/xConst*
value	B :P*
dtype0*
_output_shapes
: 
D
sub_53Subsub_53/x
Maximum_31*
_output_shapes
: *
T0
B
sub_54Subsub_53
unstack_30*
T0*
_output_shapes
: 
S
GreaterEqual_60/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_60GreaterEqual
Maximum_31GreaterEqual_60/y*
T0*
_output_shapes
: 
j
Assert_76/ConstConst*+
value"B  Boffset_height must be >= 0*
_output_shapes
: *
dtype0
r
Assert_76/Assert/data_0Const*
_output_shapes
: *
dtype0*+
value"B  Boffset_height must be >= 0
a
Assert_76/AssertAssertGreaterEqual_60Assert_76/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_61/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_61GreaterEqual
Maximum_29GreaterEqual_61/y*
T0*
_output_shapes
: 
i
Assert_77/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_77/Assert/data_0Const**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_77/AssertAssertGreaterEqual_61Assert_77/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_62/yConst*
_output_shapes
: *
dtype0*
value	B : 
[
GreaterEqual_62GreaterEqualsub_52GreaterEqual_62/y*
T0*
_output_shapes
: 
p
Assert_78/ConstConst*
dtype0*
_output_shapes
: *1
value(B& B width must be <= target - offset
x
Assert_78/Assert/data_0Const*
_output_shapes
: *
dtype0*1
value(B& B width must be <= target - offset
a
Assert_78/AssertAssertGreaterEqual_62Assert_78/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_63/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_63GreaterEqualsub_54GreaterEqual_63/y*
_output_shapes
: *
T0
q
Assert_79/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
y
Assert_79/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_79/AssertAssertGreaterEqual_63Assert_79/Assert/data_0*

T
2*
	summarize

control_dependency_30IdentitySlice_7-^assert_positive_23/assert_less/Assert/Assert^Assert_76/Assert^Assert_77/Assert^Assert_78/Assert^Assert_79/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_7*
T0
L

stack_23/4Const*
dtype0*
_output_shapes
: *
value	B : 
L

stack_23/5Const*
value	B : *
_output_shapes
: *
dtype0

stack_23Pack
Maximum_31sub_54
Maximum_29sub_52
stack_23/4
stack_23/5*
_output_shapes
:*
N*

axis *
T0
a
Reshape_14/shapeConst*
valueB"      *
dtype0*
_output_shapes
:
h

Reshape_14Reshapestack_23Reshape_14/shape*
Tshape0*
_output_shapes

:*
T0
w
Pad_7Padcontrol_dependency_30
Reshape_14*
T0*
	Tpaddings0*,
_output_shapes
:Pџџџџџџџџџ
M
Shape_55ShapePad_7*
T0*
_output_shapes
:*
out_type0
Z

unstack_31UnpackShape_55*
_output_shapes
: : : *

axis *	
num*
T0
y
control_dependency_31IdentityPad_7*
T0*,
_output_shapes
:Pџџџџџџџџџ*
_class

loc:@Pad_7
e
Reshape_15/shapeConst*!
valueB"P         *
dtype0*
_output_shapes
:
z

Reshape_15Reshapecontrol_dependency_31Reshape_15/shape*
T0*#
_output_shapes
:P*
Tshape0
Z
	ToFloat_7Cast
Reshape_15*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_7/yConst*
valueB
 *  C*
_output_shapes
: *
dtype0
R
div_7RealDiv	ToFloat_7div_7/y*#
_output_shapes
:P*
T0
M
sub_55/yConst*
_output_shapes
: *
dtype0*
valueB
 *   ?
L
sub_55Subdiv_7sub_55/y*
T0*#
_output_shapes
:P
v
shuffle_batch_7/ConstConst*
_output_shapes
:*
dtype0*-
value$B""              №?        
Y
shuffle_batch_7/Const_1Const*
value	B
 Z*
dtype0
*
_output_shapes
: 
ј
$shuffle_batch_7/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
shared_name *
seed2 *
	container *

seed *
capacity*
min_after_dequeue

z
shuffle_batch_7/cond/SwitchSwitchshuffle_batch_7/Const_1shuffle_batch_7/Const_1*
T0
*
_output_shapes
: : 
i
shuffle_batch_7/cond/switch_tIdentityshuffle_batch_7/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_7/cond/switch_fIdentityshuffle_batch_7/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_7/cond/pred_idIdentityshuffle_batch_7/Const_1*
_output_shapes
: *
T0

т
8shuffle_batch_7/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_7/random_shuffle_queueshuffle_batch_7/cond/pred_id*
T0*7
_class-
+)loc:@shuffle_batch_7/random_shuffle_queue*
_output_shapes
: : 
Т
:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_55shuffle_batch_7/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_55
Ю
:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_7/Constshuffle_batch_7/cond/pred_id* 
_output_shapes
::*(
_class
loc:@shuffle_batch_7/Const*
T0
­
1shuffle_batch_7/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_7/cond/control_dependencyIdentityshuffle_batch_7/cond/switch_t2^shuffle_batch_7/cond/random_shuffle_queue_enqueue*
T0
*0
_class&
$"loc:@shuffle_batch_7/cond/switch_t*
_output_shapes
: 
A
shuffle_batch_7/cond/NoOpNoOp^shuffle_batch_7/cond/switch_f
У
)shuffle_batch_7/cond/control_dependency_1Identityshuffle_batch_7/cond/switch_f^shuffle_batch_7/cond/NoOp*
T0
*0
_class&
$"loc:@shuffle_batch_7/cond/switch_f*
_output_shapes
: 
Ѓ
shuffle_batch_7/cond/MergeMerge)shuffle_batch_7/cond/control_dependency_1'shuffle_batch_7/cond/control_dependency*
T0
*
N*
_output_shapes
: : 

*shuffle_batch_7/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_7/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_7/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_7/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_7/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_7/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_7/sub/yConst*
value	B :
*
_output_shapes
: *
dtype0
}
shuffle_batch_7/subSub)shuffle_batch_7/random_shuffle_queue_Sizeshuffle_batch_7/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_7/Maximum/xConst*
value	B : *
_output_shapes
: *
dtype0
s
shuffle_batch_7/MaximumMaximumshuffle_batch_7/Maximum/xshuffle_batch_7/sub*
_output_shapes
: *
T0
e
shuffle_batch_7/CastCastshuffle_batch_7/Maximum*
_output_shapes
: *

DstT0*

SrcT0
Z
shuffle_batch_7/mul/yConst*
valueB
 *ЋЊЊ=*
_output_shapes
: *
dtype0
h
shuffle_batch_7/mulMulshuffle_batch_7/Castshuffle_batch_7/mul/y*
_output_shapes
: *
T0

0shuffle_batch_7/fraction_over_10_of_12_full/tagsConst*
dtype0*
_output_shapes
: *<
value3B1 B+shuffle_batch_7/fraction_over_10_of_12_full
Є
+shuffle_batch_7/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_7/fraction_over_10_of_12_full/tagsshuffle_batch_7/mul*
T0*
_output_shapes
: 
S
shuffle_batch_7/nConst*
dtype0*
_output_shapes
: *
value	B :
Ч
shuffle_batch_7QueueDequeueManyV2$shuffle_batch_7/random_shuffle_queueshuffle_batch_7/n*

timeout_msџџџџџџџџџ*1
_output_shapes
:P:*
component_types
2
w
*matching_filenames_8/MatchingFiles/patternConst*
valueB BTest/2/*.jpg*
dtype0*
_output_shapes
: 

"matching_filenames_8/MatchingFilesMatchingFiles*matching_filenames_8/MatchingFiles/pattern*#
_output_shapes
:џџџџџџџџџ
|
matching_filenames_8
VariableV2*
shape:*
shared_name *
dtype0*
_output_shapes
:*
	container 
п
matching_filenames_8/AssignAssignmatching_filenames_8"matching_filenames_8/MatchingFiles*
use_locking(*
validate_shape( *
T0*#
_output_shapes
:џџџџџџџџџ*'
_class
loc:@matching_filenames_8

matching_filenames_8/readIdentitymatching_filenames_8*'
_class
loc:@matching_filenames_8*
_output_shapes
:*
T0
i
input_producer_8/SizeSizematching_filenames_8/read*
T0*
_output_shapes
: *
out_type0
\
input_producer_8/Greater/yConst*
value	B : *
_output_shapes
: *
dtype0
w
input_producer_8/GreaterGreaterinput_producer_8/Sizeinput_producer_8/Greater/y*
T0*
_output_shapes
: 

input_producer_8/Assert/ConstConst*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

%input_producer_8/Assert/Assert/data_0Const*G
value>B< B6string_input_producer requires a non-null input tensor*
_output_shapes
: *
dtype0

input_producer_8/Assert/AssertAssertinput_producer_8/Greater%input_producer_8/Assert/Assert/data_0*
	summarize*

T
2

input_producer_8/IdentityIdentitymatching_filenames_8/read^input_producer_8/Assert/Assert*
T0*
_output_shapes
:

input_producer_8FIFOQueueV2*
shapes
: *
shared_name *
capacity *
	container *
_output_shapes
: *
component_types
2
Ё
-input_producer_8/input_producer_8_EnqueueManyQueueEnqueueManyV2input_producer_8input_producer_8/Identity*
Tcomponents
2*

timeout_msџџџџџџџџџ
h
'input_producer_8/input_producer_8_CloseQueueCloseV2input_producer_8*
cancel_pending_enqueues( 
j
)input_producer_8/input_producer_8_Close_1QueueCloseV2input_producer_8*
cancel_pending_enqueues(
_
&input_producer_8/input_producer_8_SizeQueueSizeV2input_producer_8*
_output_shapes
: 
u
input_producer_8/CastCast&input_producer_8/input_producer_8_Size*
_output_shapes
: *

DstT0*

SrcT0
[
input_producer_8/mul/yConst*
_output_shapes
: *
dtype0*
valueB
 *   =
k
input_producer_8/mulMulinput_producer_8/Castinput_producer_8/mul/y*
_output_shapes
: *
T0

)input_producer_8/fraction_of_32_full/tagsConst*
_output_shapes
: *
dtype0*5
value,B* B$input_producer_8/fraction_of_32_full

$input_producer_8/fraction_of_32_fullScalarSummary)input_producer_8/fraction_of_32_full/tagsinput_producer_8/mul*
_output_shapes
: *
T0
d
WholeFileReaderV2_8WholeFileReaderV2*
_output_shapes
: *
	container *
shared_name 
_
ReaderReadV2_8ReaderReadV2WholeFileReaderV2_8input_producer_8*
_output_shapes
: : 
ь
DecodeJpeg_8
DecodeJpegReaderReadV2_8:1*
fancy_upscaling(*

dct_method *
try_recover_truncated( *
channels *=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
ratio*
acceptable_fraction%  ?
T
Shape_56ShapeDecodeJpeg_8*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_24/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_24/assert_less/LessLessassert_positive_24/ConstShape_56*
_output_shapes
:*
T0
n
$assert_positive_24/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_24/assert_less/AllAll#assert_positive_24/assert_less/Less$assert_positive_24/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_24/assert_less/Assert/ConstConst*7
value.B, B&all dims of 'image.shape' must be > 0.*
_output_shapes
: *
dtype0

3assert_positive_24/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_24/assert_less/Assert/AssertAssert"assert_positive_24/assert_less/All3assert_positive_24/assert_less/Assert/Assert/data_0*

T
2*
	summarize
Ч
control_dependency_32IdentityDecodeJpeg_8-^assert_positive_24/assert_less/Assert/Assert*
_class
loc:@DecodeJpeg_8*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
T0
]
Shape_57Shapecontrol_dependency_32*
T0*
out_type0*
_output_shapes
:
Z

unstack_32UnpackShape_57*
_output_shapes
: : : *

axis *	
num*
T0
K
sub_56/xConst*
dtype0*
_output_shapes
: *
value
B :
F
sub_56Subsub_56/xunstack_32:1*
_output_shapes
: *
T0
6
Neg_16Negsub_56*
T0*
_output_shapes
: 
O
floordiv_32/yConst*
dtype0*
_output_shapes
: *
value	B :
O
floordiv_32FloorDivNeg_16floordiv_32/y*
_output_shapes
: *
T0
N
Maximum_32/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_32Maximumfloordiv_32Maximum_32/y*
T0*
_output_shapes
: 
O
floordiv_33/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_33FloorDivsub_56floordiv_33/y*
T0*
_output_shapes
: 
N
Maximum_33/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_33Maximumfloordiv_33Maximum_33/y*
T0*
_output_shapes
: 
J
sub_57/xConst*
_output_shapes
: *
dtype0*
value	B :P
D
sub_57Subsub_57/x
unstack_32*
_output_shapes
: *
T0
6
Neg_17Negsub_57*
T0*
_output_shapes
: 
O
floordiv_34/yConst*
value	B :*
_output_shapes
: *
dtype0
O
floordiv_34FloorDivNeg_17floordiv_34/y*
T0*
_output_shapes
: 
N
Maximum_34/yConst*
_output_shapes
: *
dtype0*
value	B : 
Q

Maximum_34Maximumfloordiv_34Maximum_34/y*
_output_shapes
: *
T0
O
floordiv_35/yConst*
value	B :*
dtype0*
_output_shapes
: 
O
floordiv_35FloorDivsub_57floordiv_35/y*
_output_shapes
: *
T0
N
Maximum_35/yConst*
value	B : *
_output_shapes
: *
dtype0
Q

Maximum_35Maximumfloordiv_35Maximum_35/y*
T0*
_output_shapes
: 
N
Minimum_16/xConst*
dtype0*
_output_shapes
: *
value	B :P
P

Minimum_16MinimumMinimum_16/x
unstack_32*
_output_shapes
: *
T0
O
Minimum_17/xConst*
_output_shapes
: *
dtype0*
value
B :
R

Minimum_17MinimumMinimum_17/xunstack_32:1*
T0*
_output_shapes
: 
]
Shape_58Shapecontrol_dependency_32*
T0*
out_type0*
_output_shapes
:
Z
assert_positive_25/ConstConst*
value	B : *
dtype0*
_output_shapes
: 
t
#assert_positive_25/assert_less/LessLessassert_positive_25/ConstShape_58*
T0*
_output_shapes
:
n
$assert_positive_25/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_25/assert_less/AllAll#assert_positive_25/assert_less/Less$assert_positive_25/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_25/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_25/assert_less/Assert/Assert/data_0Const*7
value.B, B&all dims of 'image.shape' must be > 0.*
dtype0*
_output_shapes
: 
Ќ
,assert_positive_25/assert_less/Assert/AssertAssert"assert_positive_25/assert_less/All3assert_positive_25/assert_less/Assert/Assert/data_0*

T
2*
	summarize
]
Shape_59Shapecontrol_dependency_32*
T0*
_output_shapes
:*
out_type0
Z

unstack_33UnpackShape_59*

axis *
_output_shapes
: : : *	
num*
T0
S
GreaterEqual_64/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_64GreaterEqual
Maximum_32GreaterEqual_64/y*
_output_shapes
: *
T0
j
Assert_80/ConstConst*+
value"B  Boffset_width must be >= 0.*
dtype0*
_output_shapes
: 
r
Assert_80/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_width must be >= 0.
a
Assert_80/AssertAssertGreaterEqual_64Assert_80/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_65/yConst*
value	B : *
_output_shapes
: *
dtype0
_
GreaterEqual_65GreaterEqual
Maximum_34GreaterEqual_65/y*
T0*
_output_shapes
: 
k
Assert_81/ConstConst*,
value#B! Boffset_height must be >= 0.*
dtype0*
_output_shapes
: 
s
Assert_81/Assert/data_0Const*,
value#B! Boffset_height must be >= 0.*
_output_shapes
: *
dtype0
a
Assert_81/AssertAssertGreaterEqual_65Assert_81/Assert/data_0*
	summarize*

T
2
N
Greater_16/yConst*
value	B : *
dtype0*
_output_shapes
: 
P

Greater_16Greater
Minimum_17Greater_16/y*
_output_shapes
: *
T0
i
Assert_82/ConstConst**
value!B Btarget_width must be > 0.*
dtype0*
_output_shapes
: 
q
Assert_82/Assert/data_0Const*
dtype0*
_output_shapes
: **
value!B Btarget_width must be > 0.
\
Assert_82/AssertAssert
Greater_16Assert_82/Assert/data_0*

T
2*
	summarize
N
Greater_17/yConst*
_output_shapes
: *
dtype0*
value	B : 
P

Greater_17Greater
Minimum_16Greater_17/y*
T0*
_output_shapes
: 
j
Assert_83/ConstConst*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
r
Assert_83/Assert/data_0Const*+
value"B  Btarget_height must be > 0.*
_output_shapes
: *
dtype0
\
Assert_83/AssertAssert
Greater_17Assert_83/Assert/data_0*

T
2*
	summarize
F
add_16Add
Minimum_17
Maximum_32*
T0*
_output_shapes
: 
V
GreaterEqual_66GreaterEqualunstack_33:1add_16*
_output_shapes
: *
T0
q
Assert_84/ConstConst*
dtype0*
_output_shapes
: *2
value)B' B!width must be >= target + offset.
y
Assert_84/Assert/data_0Const*2
value)B' B!width must be >= target + offset.*
dtype0*
_output_shapes
: 
a
Assert_84/AssertAssertGreaterEqual_66Assert_84/Assert/data_0*
	summarize*

T
2
F
add_17Add
Minimum_16
Maximum_34*
T0*
_output_shapes
: 
T
GreaterEqual_67GreaterEqual
unstack_33add_17*
_output_shapes
: *
T0
r
Assert_85/ConstConst*3
value*B( B"height must be >= target + offset.*
dtype0*
_output_shapes
: 
z
Assert_85/Assert/data_0Const*
_output_shapes
: *
dtype0*3
value*B( B"height must be >= target + offset.
a
Assert_85/AssertAssertGreaterEqual_67Assert_85/Assert/data_0*
	summarize*

T
2
Т
control_dependency_33Identitycontrol_dependency_32-^assert_positive_25/assert_less/Assert/Assert^Assert_80/Assert^Assert_81/Assert^Assert_82/Assert^Assert_83/Assert^Assert_84/Assert^Assert_85/Assert*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@DecodeJpeg_8
L

stack_24/2Const*
value	B : *
_output_shapes
: *
dtype0
n
stack_24Pack
Maximum_34
Maximum_32
stack_24/2*
_output_shapes
:*
N*

axis *
T0
U

stack_25/2Const*
valueB :
џџџџџџџџџ*
_output_shapes
: *
dtype0
n
stack_25Pack
Minimum_16
Minimum_17
stack_25/2*
_output_shapes
:*
N*

axis *
T0

Slice_8Slicecontrol_dependency_33stack_24stack_25*
Index0*
T0*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ
O
Shape_60ShapeSlice_8*
out_type0*
_output_shapes
:*
T0
Z
assert_positive_26/ConstConst*
value	B : *
_output_shapes
: *
dtype0
t
#assert_positive_26/assert_less/LessLessassert_positive_26/ConstShape_60*
T0*
_output_shapes
:
n
$assert_positive_26/assert_less/ConstConst*
valueB: *
dtype0*
_output_shapes
:
Љ
"assert_positive_26/assert_less/AllAll#assert_positive_26/assert_less/Less$assert_positive_26/assert_less/Const*

Tidx0*
	keep_dims( *
_output_shapes
: 

+assert_positive_26/assert_less/Assert/ConstConst*
_output_shapes
: *
dtype0*7
value.B, B&all dims of 'image.shape' must be > 0.

3assert_positive_26/assert_less/Assert/Assert/data_0Const*
dtype0*
_output_shapes
: *7
value.B, B&all dims of 'image.shape' must be > 0.
Ќ
,assert_positive_26/assert_less/Assert/AssertAssert"assert_positive_26/assert_less/All3assert_positive_26/assert_less/Assert/Assert/data_0*
	summarize*

T
2
O
Shape_61ShapeSlice_8*
T0*
out_type0*
_output_shapes
:
Z

unstack_34UnpackShape_61*

axis *
_output_shapes
: : : *	
num*
T0
K
sub_58/xConst*
value
B :*
_output_shapes
: *
dtype0
D
sub_58Subsub_58/x
Maximum_33*
_output_shapes
: *
T0
D
sub_59Subsub_58unstack_34:1*
_output_shapes
: *
T0
J
sub_60/xConst*
_output_shapes
: *
dtype0*
value	B :P
D
sub_60Subsub_60/x
Maximum_35*
T0*
_output_shapes
: 
B
sub_61Subsub_60
unstack_34*
_output_shapes
: *
T0
S
GreaterEqual_68/yConst*
_output_shapes
: *
dtype0*
value	B : 
_
GreaterEqual_68GreaterEqual
Maximum_35GreaterEqual_68/y*
_output_shapes
: *
T0
j
Assert_86/ConstConst*+
value"B  Boffset_height must be >= 0*
dtype0*
_output_shapes
: 
r
Assert_86/Assert/data_0Const*
dtype0*
_output_shapes
: *+
value"B  Boffset_height must be >= 0
a
Assert_86/AssertAssertGreaterEqual_68Assert_86/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_69/yConst*
value	B : *
dtype0*
_output_shapes
: 
_
GreaterEqual_69GreaterEqual
Maximum_33GreaterEqual_69/y*
_output_shapes
: *
T0
i
Assert_87/ConstConst*
dtype0*
_output_shapes
: **
value!B Boffset_width must be >= 0
q
Assert_87/Assert/data_0Const**
value!B Boffset_width must be >= 0*
dtype0*
_output_shapes
: 
a
Assert_87/AssertAssertGreaterEqual_69Assert_87/Assert/data_0*

T
2*
	summarize
S
GreaterEqual_70/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_70GreaterEqualsub_59GreaterEqual_70/y*
_output_shapes
: *
T0
p
Assert_88/ConstConst*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
x
Assert_88/Assert/data_0Const*1
value(B& B width must be <= target - offset*
_output_shapes
: *
dtype0
a
Assert_88/AssertAssertGreaterEqual_70Assert_88/Assert/data_0*
	summarize*

T
2
S
GreaterEqual_71/yConst*
dtype0*
_output_shapes
: *
value	B : 
[
GreaterEqual_71GreaterEqualsub_61GreaterEqual_71/y*
_output_shapes
: *
T0
q
Assert_89/ConstConst*2
value)B' B!height must be <= target - offset*
_output_shapes
: *
dtype0
y
Assert_89/Assert/data_0Const*
dtype0*
_output_shapes
: *2
value)B' B!height must be <= target - offset
a
Assert_89/AssertAssertGreaterEqual_71Assert_89/Assert/data_0*
	summarize*

T
2

control_dependency_34IdentitySlice_8-^assert_positive_26/assert_less/Assert/Assert^Assert_86/Assert^Assert_87/Assert^Assert_88/Assert^Assert_89/Assert*=
_output_shapes+
):'џџџџџџџџџџџџџџџџџџџџџџџџџџџ*
_class
loc:@Slice_8*
T0
L

stack_26/4Const*
value	B : *
dtype0*
_output_shapes
: 
L

stack_26/5Const*
value	B : *
dtype0*
_output_shapes
: 

stack_26Pack
Maximum_35sub_61
Maximum_33sub_59
stack_26/4
stack_26/5*

axis *
_output_shapes
:*
T0*
N
a
Reshape_16/shapeConst*
valueB"      *
dtype0*
_output_shapes
:
h

Reshape_16Reshapestack_26Reshape_16/shape*
T0*
_output_shapes

:*
Tshape0
w
Pad_8Padcontrol_dependency_34
Reshape_16*,
_output_shapes
:Pџџџџџџџџџ*
	Tpaddings0*
T0
M
Shape_62ShapePad_8*
_output_shapes
:*
out_type0*
T0
Z

unstack_35UnpackShape_62*	
num*
T0*

axis *
_output_shapes
: : : 
y
control_dependency_35IdentityPad_8*
T0*
_class

loc:@Pad_8*,
_output_shapes
:Pџџџџџџџџџ
e
Reshape_17/shapeConst*!
valueB"P         *
_output_shapes
:*
dtype0
z

Reshape_17Reshapecontrol_dependency_35Reshape_17/shape*
T0*#
_output_shapes
:P*
Tshape0
Z
	ToFloat_8Cast
Reshape_17*#
_output_shapes
:P*

DstT0*

SrcT0
L
div_8/yConst*
dtype0*
_output_shapes
: *
valueB
 *  C
R
div_8RealDiv	ToFloat_8div_8/y*
T0*#
_output_shapes
:P
M
sub_62/yConst*
dtype0*
_output_shapes
: *
valueB
 *   ?
L
sub_62Subdiv_8sub_62/y*#
_output_shapes
:P*
T0
v
shuffle_batch_8/ConstConst*
dtype0*
_output_shapes
:*-
value$B""                      №?
Y
shuffle_batch_8/Const_1Const*
_output_shapes
: *
dtype0
*
value	B
 Z
ј
$shuffle_batch_8/random_shuffle_queueRandomShuffleQueueV2*!
shapes
:P:*
_output_shapes
: *
component_types
2*
shared_name *
seed2 *
	container *

seed *
capacity*
min_after_dequeue

z
shuffle_batch_8/cond/SwitchSwitchshuffle_batch_8/Const_1shuffle_batch_8/Const_1*
T0
*
_output_shapes
: : 
i
shuffle_batch_8/cond/switch_tIdentityshuffle_batch_8/cond/Switch:1*
T0
*
_output_shapes
: 
g
shuffle_batch_8/cond/switch_fIdentityshuffle_batch_8/cond/Switch*
_output_shapes
: *
T0

b
shuffle_batch_8/cond/pred_idIdentityshuffle_batch_8/Const_1*
T0
*
_output_shapes
: 
т
8shuffle_batch_8/cond/random_shuffle_queue_enqueue/SwitchSwitch$shuffle_batch_8/random_shuffle_queueshuffle_batch_8/cond/pred_id*
_output_shapes
: : *7
_class-
+)loc:@shuffle_batch_8/random_shuffle_queue*
T0
Т
:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1Switchsub_62shuffle_batch_8/cond/pred_id*
T0*2
_output_shapes 
:P:P*
_class
loc:@sub_62
Ю
:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2Switchshuffle_batch_8/Constshuffle_batch_8/cond/pred_id* 
_output_shapes
::*(
_class
loc:@shuffle_batch_8/Const*
T0
­
1shuffle_batch_8/cond/random_shuffle_queue_enqueueQueueEnqueueV2:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch:1<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1:1<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2:1*
Tcomponents
2*

timeout_msџџџџџџџџџ
й
'shuffle_batch_8/cond/control_dependencyIdentityshuffle_batch_8/cond/switch_t2^shuffle_batch_8/cond/random_shuffle_queue_enqueue*0
_class&
$"loc:@shuffle_batch_8/cond/switch_t*
_output_shapes
: *
T0

A
shuffle_batch_8/cond/NoOpNoOp^shuffle_batch_8/cond/switch_f
У
)shuffle_batch_8/cond/control_dependency_1Identityshuffle_batch_8/cond/switch_f^shuffle_batch_8/cond/NoOp*0
_class&
$"loc:@shuffle_batch_8/cond/switch_f*
_output_shapes
: *
T0

Ѓ
shuffle_batch_8/cond/MergeMerge)shuffle_batch_8/cond/control_dependency_1'shuffle_batch_8/cond/control_dependency*
N*
T0
*
_output_shapes
: : 

*shuffle_batch_8/random_shuffle_queue_CloseQueueCloseV2$shuffle_batch_8/random_shuffle_queue*
cancel_pending_enqueues( 

,shuffle_batch_8/random_shuffle_queue_Close_1QueueCloseV2$shuffle_batch_8/random_shuffle_queue*
cancel_pending_enqueues(
v
)shuffle_batch_8/random_shuffle_queue_SizeQueueSizeV2$shuffle_batch_8/random_shuffle_queue*
_output_shapes
: 
W
shuffle_batch_8/sub/yConst*
_output_shapes
: *
dtype0*
value	B :

}
shuffle_batch_8/subSub)shuffle_batch_8/random_shuffle_queue_Sizeshuffle_batch_8/sub/y*
_output_shapes
: *
T0
[
shuffle_batch_8/Maximum/xConst*
dtype0*
_output_shapes
: *
value	B : 
s
shuffle_batch_8/MaximumMaximumshuffle_batch_8/Maximum/xshuffle_batch_8/sub*
T0*
_output_shapes
: 
e
shuffle_batch_8/CastCastshuffle_batch_8/Maximum*

SrcT0*
_output_shapes
: *

DstT0
Z
shuffle_batch_8/mul/yConst*
dtype0*
_output_shapes
: *
valueB
 *ЋЊЊ=
h
shuffle_batch_8/mulMulshuffle_batch_8/Castshuffle_batch_8/mul/y*
T0*
_output_shapes
: 

0shuffle_batch_8/fraction_over_10_of_12_full/tagsConst*<
value3B1 B+shuffle_batch_8/fraction_over_10_of_12_full*
dtype0*
_output_shapes
: 
Є
+shuffle_batch_8/fraction_over_10_of_12_fullScalarSummary0shuffle_batch_8/fraction_over_10_of_12_full/tagsshuffle_batch_8/mul*
T0*
_output_shapes
: 
S
shuffle_batch_8/nConst*
value	B :*
_output_shapes
: *
dtype0
Ч
shuffle_batch_8QueueDequeueManyV2$shuffle_batch_8/random_shuffle_queueshuffle_batch_8/n*1
_output_shapes
:P:*
component_types
2*

timeout_msџџџџџџџџџ
O
concat_4/axisConst*
dtype0*
_output_shapes
: *
value	B : 

concat_4ConcatV2shuffle_batch_6shuffle_batch_7shuffle_batch_8concat_4/axis*

Tidx0*
T0*
N*'
_output_shapes
:P
O
concat_5/axisConst*
_output_shapes
: *
dtype0*
value	B : 

concat_5ConcatV2shuffle_batch_6:1shuffle_batch_7:1shuffle_batch_8:1concat_5/axis*
_output_shapes

:*
T0*

Tidx0*
N
Й
6ConvNet/conv2d/kernel/Initializer/random_uniform/shapeConst*
_output_shapes
:*
dtype0*(
_class
loc:@ConvNet/conv2d/kernel*%
valueB"             
Ѓ
4ConvNet/conv2d/kernel/Initializer/random_uniform/minConst*
dtype0*
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel*
valueB
 *О
Ѓ
4ConvNet/conv2d/kernel/Initializer/random_uniform/maxConst*
dtype0*
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel*
valueB
 *>

>ConvNet/conv2d/kernel/Initializer/random_uniform/RandomUniformRandomUniform6ConvNet/conv2d/kernel/Initializer/random_uniform/shape*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: *
T0*
dtype0*
seed2 *

seed 
ђ
4ConvNet/conv2d/kernel/Initializer/random_uniform/subSub4ConvNet/conv2d/kernel/Initializer/random_uniform/max4ConvNet/conv2d/kernel/Initializer/random_uniform/min*(
_class
loc:@ConvNet/conv2d/kernel*
_output_shapes
: *
T0

4ConvNet/conv2d/kernel/Initializer/random_uniform/mulMul>ConvNet/conv2d/kernel/Initializer/random_uniform/RandomUniform4ConvNet/conv2d/kernel/Initializer/random_uniform/sub*&
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel*
T0
ў
0ConvNet/conv2d/kernel/Initializer/random_uniformAdd4ConvNet/conv2d/kernel/Initializer/random_uniform/mul4ConvNet/conv2d/kernel/Initializer/random_uniform/min*
T0*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: 
У
ConvNet/conv2d/kernel
VariableV2*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: *
shape: *
dtype0*
shared_name *
	container 
ѓ
ConvNet/conv2d/kernel/AssignAssignConvNet/conv2d/kernel0ConvNet/conv2d/kernel/Initializer/random_uniform*
use_locking(*
validate_shape(*
T0*&
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel

ConvNet/conv2d/kernel/readIdentityConvNet/conv2d/kernel*
T0*(
_class
loc:@ConvNet/conv2d/kernel*&
_output_shapes
: 

%ConvNet/conv2d/bias/Initializer/ConstConst*&
_class
loc:@ConvNet/conv2d/bias*
valueB *    *
dtype0*
_output_shapes
: 
Ї
ConvNet/conv2d/bias
VariableV2*&
_class
loc:@ConvNet/conv2d/bias*
_output_shapes
: *
shape: *
dtype0*
shared_name *
	container 
ж
ConvNet/conv2d/bias/AssignAssignConvNet/conv2d/bias%ConvNet/conv2d/bias/Initializer/Const*&
_class
loc:@ConvNet/conv2d/bias*
_output_shapes
: *
T0*
validate_shape(*
use_locking(

ConvNet/conv2d/bias/readIdentityConvNet/conv2d/bias*
T0*
_output_shapes
: *&
_class
loc:@ConvNet/conv2d/bias
y
 ConvNet/conv2d/convolution/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"             
y
(ConvNet/conv2d/convolution/dilation_rateConst*
valueB"      *
_output_shapes
:*
dtype0
в
ConvNet/conv2d/convolutionConv2DconcatConvNet/conv2d/kernel/read*
paddingVALID*
T0*
strides
*
data_formatNHWC*'
_output_shapes
:N *
use_cudnn_on_gpu(
 
ConvNet/conv2d/BiasAddBiasAddConvNet/conv2d/convolutionConvNet/conv2d/bias/read*'
_output_shapes
:N *
T0*
data_formatNHWC
e
ConvNet/conv2d/ReluReluConvNet/conv2d/BiasAdd*
T0*'
_output_shapes
:N 
С
ConvNet/max_pooling2d/MaxPoolMaxPoolConvNet/conv2d/Relu*
ksize
*&
_output_shapes
:'E *
strides
*
data_formatNHWC*
T0*
paddingVALID
Н
8ConvNet/conv2d_1/kernel/Initializer/random_uniform/shapeConst**
_class 
loc:@ConvNet/conv2d_1/kernel*%
valueB"          @   *
_output_shapes
:*
dtype0
Ї
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/minConst*
_output_shapes
: *
dtype0**
_class 
loc:@ConvNet/conv2d_1/kernel*
valueB
 *ЋЊЊН
Ї
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/maxConst**
_class 
loc:@ConvNet/conv2d_1/kernel*
valueB
 *ЋЊЊ=*
dtype0*
_output_shapes
: 

@ConvNet/conv2d_1/kernel/Initializer/random_uniform/RandomUniformRandomUniform8ConvNet/conv2d_1/kernel/Initializer/random_uniform/shape*
seed2 *
T0*

seed *
dtype0**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @
њ
6ConvNet/conv2d_1/kernel/Initializer/random_uniform/subSub6ConvNet/conv2d_1/kernel/Initializer/random_uniform/max6ConvNet/conv2d_1/kernel/Initializer/random_uniform/min*
_output_shapes
: **
_class 
loc:@ConvNet/conv2d_1/kernel*
T0

6ConvNet/conv2d_1/kernel/Initializer/random_uniform/mulMul@ConvNet/conv2d_1/kernel/Initializer/random_uniform/RandomUniform6ConvNet/conv2d_1/kernel/Initializer/random_uniform/sub*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel*
T0

2ConvNet/conv2d_1/kernel/Initializer/random_uniformAdd6ConvNet/conv2d_1/kernel/Initializer/random_uniform/mul6ConvNet/conv2d_1/kernel/Initializer/random_uniform/min*
T0**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @
Ч
ConvNet/conv2d_1/kernel
VariableV2*
shared_name **
_class 
loc:@ConvNet/conv2d_1/kernel*
	container *
shape: @*
dtype0*&
_output_shapes
: @
ћ
ConvNet/conv2d_1/kernel/AssignAssignConvNet/conv2d_1/kernel2ConvNet/conv2d_1/kernel/Initializer/random_uniform*
use_locking(*
T0**
_class 
loc:@ConvNet/conv2d_1/kernel*
validate_shape(*&
_output_shapes
: @

ConvNet/conv2d_1/kernel/readIdentityConvNet/conv2d_1/kernel*&
_output_shapes
: @**
_class 
loc:@ConvNet/conv2d_1/kernel*
T0

'ConvNet/conv2d_1/bias/Initializer/ConstConst*(
_class
loc:@ConvNet/conv2d_1/bias*
valueB@*    *
_output_shapes
:@*
dtype0
Ћ
ConvNet/conv2d_1/bias
VariableV2*
	container *
dtype0*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@*
shape:@*
shared_name 
о
ConvNet/conv2d_1/bias/AssignAssignConvNet/conv2d_1/bias'ConvNet/conv2d_1/bias/Initializer/Const*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@*
T0*
validate_shape(*
use_locking(

ConvNet/conv2d_1/bias/readIdentityConvNet/conv2d_1/bias*
T0*(
_class
loc:@ConvNet/conv2d_1/bias*
_output_shapes
:@
{
"ConvNet/conv2d_2/convolution/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"          @   
{
*ConvNet/conv2d_2/convolution/dilation_rateConst*
valueB"      *
_output_shapes
:*
dtype0
ь
ConvNet/conv2d_2/convolutionConv2DConvNet/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*
paddingVALID*
strides
*
data_formatNHWC*
use_cudnn_on_gpu(*
T0*&
_output_shapes
:%C@
Ѕ
ConvNet/conv2d_2/BiasAddBiasAddConvNet/conv2d_2/convolutionConvNet/conv2d_1/bias/read*&
_output_shapes
:%C@*
data_formatNHWC*
T0
h
ConvNet/conv2d_2/ReluReluConvNet/conv2d_2/BiasAdd*&
_output_shapes
:%C@*
T0
Х
ConvNet/max_pooling2d_2/MaxPoolMaxPoolConvNet/conv2d_2/Relu*
strides
*
data_formatNHWC*&
_output_shapes
:!@*
paddingVALID*
T0*
ksize

f
ConvNet/Reshape/shapeConst*
_output_shapes
:*
dtype0*
valueB"     

ConvNet/ReshapeReshapeConvNet/max_pooling2d_2/MaxPoolConvNet/Reshape/shape*
T0* 
_output_shapes
:
Љ*
Tshape0
Џ
5ConvNet/dense/kernel/Initializer/random_uniform/shapeConst*
dtype0*
_output_shapes
:*'
_class
loc:@ConvNet/dense/kernel*
valueB"     
Ё
3ConvNet/dense/kernel/Initializer/random_uniform/minConst*'
_class
loc:@ConvNet/dense/kernel*
valueB
 *vбMМ*
_output_shapes
: *
dtype0
Ё
3ConvNet/dense/kernel/Initializer/random_uniform/maxConst*
_output_shapes
: *
dtype0*'
_class
loc:@ConvNet/dense/kernel*
valueB
 *vбM<
џ
=ConvNet/dense/kernel/Initializer/random_uniform/RandomUniformRandomUniform5ConvNet/dense/kernel/Initializer/random_uniform/shape*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0*
dtype0*
seed2 *

seed 
ю
3ConvNet/dense/kernel/Initializer/random_uniform/subSub3ConvNet/dense/kernel/Initializer/random_uniform/max3ConvNet/dense/kernel/Initializer/random_uniform/min*'
_class
loc:@ConvNet/dense/kernel*
_output_shapes
: *
T0

3ConvNet/dense/kernel/Initializer/random_uniform/mulMul=ConvNet/dense/kernel/Initializer/random_uniform/RandomUniform3ConvNet/dense/kernel/Initializer/random_uniform/sub*
T0* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel
є
/ConvNet/dense/kernel/Initializer/random_uniformAdd3ConvNet/dense/kernel/Initializer/random_uniform/mul3ConvNet/dense/kernel/Initializer/random_uniform/min*
T0*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ
Е
ConvNet/dense/kernel
VariableV2*
	container *
shared_name *
dtype0*
shape:
Љ* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel
щ
ConvNet/dense/kernel/AssignAssignConvNet/dense/kernel/ConvNet/dense/kernel/Initializer/random_uniform*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0*
validate_shape(*
use_locking(

ConvNet/dense/kernel/readIdentityConvNet/dense/kernel* 
_output_shapes
:
Љ*'
_class
loc:@ConvNet/dense/kernel*
T0

$ConvNet/dense/bias/Initializer/ConstConst*%
_class
loc:@ConvNet/dense/bias*
valueB*    *
_output_shapes
:*
dtype0
Ѕ
ConvNet/dense/bias
VariableV2*
shared_name *
shape:*
_output_shapes
:*%
_class
loc:@ConvNet/dense/bias*
dtype0*
	container 
в
ConvNet/dense/bias/AssignAssignConvNet/dense/bias$ConvNet/dense/bias/Initializer/Const*%
_class
loc:@ConvNet/dense/bias*
_output_shapes
:*
T0*
validate_shape(*
use_locking(

ConvNet/dense/bias/readIdentityConvNet/dense/bias*
_output_shapes
:*%
_class
loc:@ConvNet/dense/bias*
T0

ConvNet/dense/MatMulMatMulConvNet/ReshapeConvNet/dense/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet/dense/BiasAddBiasAddConvNet/dense/MatMulConvNet/dense/bias/read*
_output_shapes

:*
data_formatNHWC*
T0
Z
ConvNet/dense/ReluReluConvNet/dense/BiasAdd*
T0*
_output_shapes

:
Г
7ConvNet/dense_1/kernel/Initializer/random_uniform/shapeConst*)
_class
loc:@ConvNet/dense_1/kernel*
valueB"      *
_output_shapes
:*
dtype0
Ѕ
5ConvNet/dense_1/kernel/Initializer/random_uniform/minConst*
dtype0*
_output_shapes
: *)
_class
loc:@ConvNet/dense_1/kernel*
valueB
 *зГ]П
Ѕ
5ConvNet/dense_1/kernel/Initializer/random_uniform/maxConst*)
_class
loc:@ConvNet/dense_1/kernel*
valueB
 *зГ]?*
dtype0*
_output_shapes
: 

?ConvNet/dense_1/kernel/Initializer/random_uniform/RandomUniformRandomUniform7ConvNet/dense_1/kernel/Initializer/random_uniform/shape*

seed *
seed2 *
dtype0*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
і
5ConvNet/dense_1/kernel/Initializer/random_uniform/subSub5ConvNet/dense_1/kernel/Initializer/random_uniform/max5ConvNet/dense_1/kernel/Initializer/random_uniform/min*)
_class
loc:@ConvNet/dense_1/kernel*
_output_shapes
: *
T0

5ConvNet/dense_1/kernel/Initializer/random_uniform/mulMul?ConvNet/dense_1/kernel/Initializer/random_uniform/RandomUniform5ConvNet/dense_1/kernel/Initializer/random_uniform/sub*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
њ
1ConvNet/dense_1/kernel/Initializer/random_uniformAdd5ConvNet/dense_1/kernel/Initializer/random_uniform/mul5ConvNet/dense_1/kernel/Initializer/random_uniform/min*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
Е
ConvNet/dense_1/kernel
VariableV2*
	container *
dtype0*)
_class
loc:@ConvNet/dense_1/kernel*
shared_name *
_output_shapes

:*
shape
:
я
ConvNet/dense_1/kernel/AssignAssignConvNet/dense_1/kernel1ConvNet/dense_1/kernel/Initializer/random_uniform*
use_locking(*
validate_shape(*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel

ConvNet/dense_1/kernel/readIdentityConvNet/dense_1/kernel*
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel

&ConvNet/dense_1/bias/Initializer/ConstConst*
_output_shapes
:*
dtype0*'
_class
loc:@ConvNet/dense_1/bias*
valueB*    
Љ
ConvNet/dense_1/bias
VariableV2*
shape:*
_output_shapes
:*
shared_name *'
_class
loc:@ConvNet/dense_1/bias*
dtype0*
	container 
к
ConvNet/dense_1/bias/AssignAssignConvNet/dense_1/bias&ConvNet/dense_1/bias/Initializer/Const*'
_class
loc:@ConvNet/dense_1/bias*
_output_shapes
:*
T0*
validate_shape(*
use_locking(

ConvNet/dense_1/bias/readIdentityConvNet/dense_1/bias*'
_class
loc:@ConvNet/dense_1/bias*
_output_shapes
:*
T0
 
ConvNet/dense_2/MatMulMatMulConvNet/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet/dense_2/BiasAddBiasAddConvNet/dense_2/MatMulConvNet/dense_1/bias/read*
data_formatNHWC*
T0*
_output_shapes

:
d
ConvNet/dense_2/SoftmaxSoftmaxConvNet/dense_2/BiasAdd*
T0*
_output_shapes

:
{
"ConvNet_1/conv2d/convolution/ShapeConst*%
valueB"             *
dtype0*
_output_shapes
:
{
*ConvNet_1/conv2d/convolution/dilation_rateConst*
dtype0*
_output_shapes
:*
valueB"      
ж
ConvNet_1/conv2d/convolutionConv2Dconcat_2ConvNet/conv2d/kernel/read*
paddingVALID*
data_formatNHWC*
strides
*
use_cudnn_on_gpu(*
T0*'
_output_shapes
:N 
Є
ConvNet_1/conv2d/BiasAddBiasAddConvNet_1/conv2d/convolutionConvNet/conv2d/bias/read*'
_output_shapes
:N *
data_formatNHWC*
T0
i
ConvNet_1/conv2d/ReluReluConvNet_1/conv2d/BiasAdd*
T0*'
_output_shapes
:N 
Х
ConvNet_1/max_pooling2d/MaxPoolMaxPoolConvNet_1/conv2d/Relu*
T0*
data_formatNHWC*
strides
*
ksize
*
paddingVALID*&
_output_shapes
:'E 
}
$ConvNet_1/conv2d_2/convolution/ShapeConst*
dtype0*
_output_shapes
:*%
valueB"          @   
}
,ConvNet_1/conv2d_2/convolution/dilation_rateConst*
valueB"      *
_output_shapes
:*
dtype0
№
ConvNet_1/conv2d_2/convolutionConv2DConvNet_1/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*&
_output_shapes
:%C@*
paddingVALID*
use_cudnn_on_gpu(*
data_formatNHWC*
strides
*
T0
Љ
ConvNet_1/conv2d_2/BiasAddBiasAddConvNet_1/conv2d_2/convolutionConvNet/conv2d_1/bias/read*
T0*
data_formatNHWC*&
_output_shapes
:%C@
l
ConvNet_1/conv2d_2/ReluReluConvNet_1/conv2d_2/BiasAdd*
T0*&
_output_shapes
:%C@
Щ
!ConvNet_1/max_pooling2d_2/MaxPoolMaxPoolConvNet_1/conv2d_2/Relu*
ksize
*
T0*
paddingVALID*&
_output_shapes
:!@*
data_formatNHWC*
strides

h
ConvNet_1/Reshape/shapeConst*
valueB"     *
_output_shapes
:*
dtype0

ConvNet_1/ReshapeReshape!ConvNet_1/max_pooling2d_2/MaxPoolConvNet_1/Reshape/shape*
Tshape0* 
_output_shapes
:
Љ*
T0

ConvNet_1/dense/MatMulMatMulConvNet_1/ReshapeConvNet/dense/kernel/read*
transpose_b( *
T0*
_output_shapes

:*
transpose_a( 

ConvNet_1/dense/BiasAddBiasAddConvNet_1/dense/MatMulConvNet/dense/bias/read*
data_formatNHWC*
T0*
_output_shapes

:
^
ConvNet_1/dense/ReluReluConvNet_1/dense/BiasAdd*
_output_shapes

:*
T0
Є
ConvNet_1/dense_2/MatMulMatMulConvNet_1/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_1/dense_2/BiasAddBiasAddConvNet_1/dense_2/MatMulConvNet/dense_1/bias/read*
T0*
data_formatNHWC*
_output_shapes

:
h
ConvNet_1/dense_2/SoftmaxSoftmaxConvNet_1/dense_2/BiasAdd*
_output_shapes

:*
T0
{
"ConvNet_2/conv2d/convolution/ShapeConst*%
valueB"             *
_output_shapes
:*
dtype0
{
*ConvNet_2/conv2d/convolution/dilation_rateConst*
_output_shapes
:*
dtype0*
valueB"      
ж
ConvNet_2/conv2d/convolutionConv2Dconcat_4ConvNet/conv2d/kernel/read*
paddingVALID*
T0*
data_formatNHWC*
strides
*'
_output_shapes
:N *
use_cudnn_on_gpu(
Є
ConvNet_2/conv2d/BiasAddBiasAddConvNet_2/conv2d/convolutionConvNet/conv2d/bias/read*
data_formatNHWC*
T0*'
_output_shapes
:N 
i
ConvNet_2/conv2d/ReluReluConvNet_2/conv2d/BiasAdd*
T0*'
_output_shapes
:N 
Х
ConvNet_2/max_pooling2d/MaxPoolMaxPoolConvNet_2/conv2d/Relu*&
_output_shapes
:'E *
paddingVALID*
ksize
*
data_formatNHWC*
strides
*
T0
}
$ConvNet_2/conv2d_2/convolution/ShapeConst*%
valueB"          @   *
_output_shapes
:*
dtype0
}
,ConvNet_2/conv2d_2/convolution/dilation_rateConst*
valueB"      *
_output_shapes
:*
dtype0
№
ConvNet_2/conv2d_2/convolutionConv2DConvNet_2/max_pooling2d/MaxPoolConvNet/conv2d_1/kernel/read*
use_cudnn_on_gpu(*
T0*
paddingVALID*&
_output_shapes
:%C@*
data_formatNHWC*
strides

Љ
ConvNet_2/conv2d_2/BiasAddBiasAddConvNet_2/conv2d_2/convolutionConvNet/conv2d_1/bias/read*&
_output_shapes
:%C@*
data_formatNHWC*
T0
l
ConvNet_2/conv2d_2/ReluReluConvNet_2/conv2d_2/BiasAdd*
T0*&
_output_shapes
:%C@
Щ
!ConvNet_2/max_pooling2d_2/MaxPoolMaxPoolConvNet_2/conv2d_2/Relu*
ksize
*
T0*
paddingVALID*&
_output_shapes
:!@*
data_formatNHWC*
strides

h
ConvNet_2/Reshape/shapeConst*
dtype0*
_output_shapes
:*
valueB"     

ConvNet_2/ReshapeReshape!ConvNet_2/max_pooling2d_2/MaxPoolConvNet_2/Reshape/shape* 
_output_shapes
:
Љ*
Tshape0*
T0

ConvNet_2/dense/MatMulMatMulConvNet_2/ReshapeConvNet/dense/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_2/dense/BiasAddBiasAddConvNet_2/dense/MatMulConvNet/dense/bias/read*
_output_shapes

:*
data_formatNHWC*
T0
^
ConvNet_2/dense/ReluReluConvNet_2/dense/BiasAdd*
_output_shapes

:*
T0
Є
ConvNet_2/dense_2/MatMulMatMulConvNet_2/dense/ReluConvNet/dense_1/kernel/read*
transpose_b( *
_output_shapes

:*
transpose_a( *
T0

ConvNet_2/dense_2/BiasAddBiasAddConvNet_2/dense_2/MatMulConvNet/dense_1/bias/read*
data_formatNHWC*
T0*
_output_shapes

:
h
ConvNet_2/dense_2/SoftmaxSoftmaxConvNet_2/dense_2/BiasAdd*
T0*
_output_shapes

:
]
CastCastConvNet/dense_2/Softmax*

SrcT0*
_output_shapes

:*

DstT0
F
sub_63SubCastconcat_1*
_output_shapes

:*
T0
A
SquareSquaresub_63*
T0*
_output_shapes

:
V
ConstConst*
dtype0*
_output_shapes
:*
valueB"       
W
SumSumSquareConst*
_output_shapes
: *
T0*
	keep_dims( *

Tidx0
a
Cast_1CastConvNet_1/dense_2/Softmax*
_output_shapes

:*

DstT0*

SrcT0
H
sub_64SubCast_1concat_3*
T0*
_output_shapes

:
C
Square_1Squaresub_64*
T0*
_output_shapes

:
X
Const_1Const*
valueB"       *
_output_shapes
:*
dtype0
]
Sum_1SumSquare_1Const_1*
_output_shapes
: *
T0*
	keep_dims( *

Tidx0
a
Cast_2CastConvNet_2/dense_2/Softmax*

SrcT0*
_output_shapes

:*

DstT0
H
sub_65SubCast_2concat_5*
T0*
_output_shapes

:
C
Square_2Squaresub_65*
T0*
_output_shapes

:
X
Const_2Const*
valueB"       *
dtype0*
_output_shapes
:
]
Sum_2SumSquare_2Const_2*
	keep_dims( *

Tidx0*
T0*
_output_shapes
: 
R
gradients/ShapeConst*
_output_shapes
: *
dtype0*
valueB 
X
gradients/ConstConst*
valueB 2      №?*
_output_shapes
: *
dtype0
Y
gradients/FillFillgradients/Shapegradients/Const*
_output_shapes
: *
T0
q
 gradients/Sum_grad/Reshape/shapeConst*
valueB"      *
_output_shapes
:*
dtype0

gradients/Sum_grad/ReshapeReshapegradients/Fill gradients/Sum_grad/Reshape/shape*
T0*
Tshape0*
_output_shapes

:
r
!gradients/Sum_grad/Tile/multiplesConst*
valueB"      *
_output_shapes
:*
dtype0

gradients/Sum_grad/TileTilegradients/Sum_grad/Reshape!gradients/Sum_grad/Tile/multiples*

Tmultiples0*
T0*
_output_shapes

:
~
gradients/Square_grad/mul/xConst^gradients/Sum_grad/Tile*
valueB 2       @*
dtype0*
_output_shapes
: 
n
gradients/Square_grad/mulMulgradients/Square_grad/mul/xsub_63*
T0*
_output_shapes

:

gradients/Square_grad/mul_1Mulgradients/Sum_grad/Tilegradients/Square_grad/mul*
T0*
_output_shapes

:
l
gradients/sub_63_grad/ShapeConst*
valueB"      *
dtype0*
_output_shapes
:
n
gradients/sub_63_grad/Shape_1Const*
_output_shapes
:*
dtype0*
valueB"      
Н
+gradients/sub_63_grad/BroadcastGradientArgsBroadcastGradientArgsgradients/sub_63_grad/Shapegradients/sub_63_grad/Shape_1*2
_output_shapes 
:џџџџџџџџџ:џџџџџџџџџ*
T0
Њ
gradients/sub_63_grad/SumSumgradients/Square_grad/mul_1+gradients/sub_63_grad/BroadcastGradientArgs*
_output_shapes
:*
T0*
	keep_dims( *

Tidx0

gradients/sub_63_grad/ReshapeReshapegradients/sub_63_grad/Sumgradients/sub_63_grad/Shape*
T0*
Tshape0*
_output_shapes

:
Ў
gradients/sub_63_grad/Sum_1Sumgradients/Square_grad/mul_1-gradients/sub_63_grad/BroadcastGradientArgs:1*
	keep_dims( *

Tidx0*
T0*
_output_shapes
:
`
gradients/sub_63_grad/NegNeggradients/sub_63_grad/Sum_1*
_output_shapes
:*
T0

gradients/sub_63_grad/Reshape_1Reshapegradients/sub_63_grad/Neggradients/sub_63_grad/Shape_1*
T0*
_output_shapes

:*
Tshape0
p
&gradients/sub_63_grad/tuple/group_depsNoOp^gradients/sub_63_grad/Reshape ^gradients/sub_63_grad/Reshape_1
н
.gradients/sub_63_grad/tuple/control_dependencyIdentitygradients/sub_63_grad/Reshape'^gradients/sub_63_grad/tuple/group_deps*
_output_shapes

:*0
_class&
$"loc:@gradients/sub_63_grad/Reshape*
T0
у
0gradients/sub_63_grad/tuple/control_dependency_1Identitygradients/sub_63_grad/Reshape_1'^gradients/sub_63_grad/tuple/group_deps*2
_class(
&$loc:@gradients/sub_63_grad/Reshape_1*
_output_shapes

:*
T0

gradients/Cast_grad/CastCast.gradients/sub_63_grad/tuple/control_dependency*
_output_shapes

:*

DstT0*

SrcT0

*gradients/ConvNet/dense_2/Softmax_grad/mulMulgradients/Cast_grad/CastConvNet/dense_2/Softmax*
_output_shapes

:*
T0

<gradients/ConvNet/dense_2/Softmax_grad/Sum/reduction_indicesConst*
_output_shapes
:*
dtype0*
valueB:
н
*gradients/ConvNet/dense_2/Softmax_grad/SumSum*gradients/ConvNet/dense_2/Softmax_grad/mul<gradients/ConvNet/dense_2/Softmax_grad/Sum/reduction_indices*
	keep_dims( *

Tidx0*
T0*
_output_shapes
:

4gradients/ConvNet/dense_2/Softmax_grad/Reshape/shapeConst*
dtype0*
_output_shapes
:*
valueB"џџџџ   
в
.gradients/ConvNet/dense_2/Softmax_grad/ReshapeReshape*gradients/ConvNet/dense_2/Softmax_grad/Sum4gradients/ConvNet/dense_2/Softmax_grad/Reshape/shape*
_output_shapes

:*
Tshape0*
T0
Є
*gradients/ConvNet/dense_2/Softmax_grad/subSubgradients/Cast_grad/Cast.gradients/ConvNet/dense_2/Softmax_grad/Reshape*
_output_shapes

:*
T0
Ё
,gradients/ConvNet/dense_2/Softmax_grad/mul_1Mul*gradients/ConvNet/dense_2/Softmax_grad/subConvNet/dense_2/Softmax*
T0*
_output_shapes

:
Ћ
2gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGradBiasAddGrad,gradients/ConvNet/dense_2/Softmax_grad/mul_1*
data_formatNHWC*
T0*
_output_shapes
:
Ѓ
7gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_depsNoOp-^gradients/ConvNet/dense_2/Softmax_grad/mul_13^gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad

?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependencyIdentity,gradients/ConvNet/dense_2/Softmax_grad/mul_18^gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_deps*
_output_shapes

:*?
_class5
31loc:@gradients/ConvNet/dense_2/Softmax_grad/mul_1*
T0
Ї
Agradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency_1Identity2gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad8^gradients/ConvNet/dense_2/BiasAdd_grad/tuple/group_deps*
_output_shapes
:*E
_class;
97loc:@gradients/ConvNet/dense_2/BiasAdd_grad/BiasAddGrad*
T0
у
,gradients/ConvNet/dense_2/MatMul_grad/MatMulMatMul?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependencyConvNet/dense_1/kernel/read*
transpose_b(*
T0*
_output_shapes

:*
transpose_a( 
м
.gradients/ConvNet/dense_2/MatMul_grad/MatMul_1MatMulConvNet/dense/Relu?gradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency*
transpose_b( *
T0*
_output_shapes

:*
transpose_a(

6gradients/ConvNet/dense_2/MatMul_grad/tuple/group_depsNoOp-^gradients/ConvNet/dense_2/MatMul_grad/MatMul/^gradients/ConvNet/dense_2/MatMul_grad/MatMul_1

>gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependencyIdentity,gradients/ConvNet/dense_2/MatMul_grad/MatMul7^gradients/ConvNet/dense_2/MatMul_grad/tuple/group_deps*
T0*?
_class5
31loc:@gradients/ConvNet/dense_2/MatMul_grad/MatMul*
_output_shapes

:
Ё
@gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependency_1Identity.gradients/ConvNet/dense_2/MatMul_grad/MatMul_17^gradients/ConvNet/dense_2/MatMul_grad/tuple/group_deps*
T0*
_output_shapes

:*A
_class7
53loc:@gradients/ConvNet/dense_2/MatMul_grad/MatMul_1
Г
*gradients/ConvNet/dense/Relu_grad/ReluGradReluGrad>gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependencyConvNet/dense/Relu*
_output_shapes

:*
T0
Ї
0gradients/ConvNet/dense/BiasAdd_grad/BiasAddGradBiasAddGrad*gradients/ConvNet/dense/Relu_grad/ReluGrad*
_output_shapes
:*
T0*
data_formatNHWC

5gradients/ConvNet/dense/BiasAdd_grad/tuple/group_depsNoOp+^gradients/ConvNet/dense/Relu_grad/ReluGrad1^gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad

=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependencyIdentity*gradients/ConvNet/dense/Relu_grad/ReluGrad6^gradients/ConvNet/dense/BiasAdd_grad/tuple/group_deps*
T0*=
_class3
1/loc:@gradients/ConvNet/dense/Relu_grad/ReluGrad*
_output_shapes

:

?gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency_1Identity0gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad6^gradients/ConvNet/dense/BiasAdd_grad/tuple/group_deps*C
_class9
75loc:@gradients/ConvNet/dense/BiasAdd_grad/BiasAddGrad*
_output_shapes
:*
T0
п
*gradients/ConvNet/dense/MatMul_grad/MatMulMatMul=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependencyConvNet/dense/kernel/read*
transpose_b(*
T0* 
_output_shapes
:
Љ*
transpose_a( 
з
,gradients/ConvNet/dense/MatMul_grad/MatMul_1MatMulConvNet/Reshape=gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency*
transpose_b( * 
_output_shapes
:
Љ*
transpose_a(*
T0

4gradients/ConvNet/dense/MatMul_grad/tuple/group_depsNoOp+^gradients/ConvNet/dense/MatMul_grad/MatMul-^gradients/ConvNet/dense/MatMul_grad/MatMul_1

<gradients/ConvNet/dense/MatMul_grad/tuple/control_dependencyIdentity*gradients/ConvNet/dense/MatMul_grad/MatMul5^gradients/ConvNet/dense/MatMul_grad/tuple/group_deps* 
_output_shapes
:
Љ*=
_class3
1/loc:@gradients/ConvNet/dense/MatMul_grad/MatMul*
T0

>gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency_1Identity,gradients/ConvNet/dense/MatMul_grad/MatMul_15^gradients/ConvNet/dense/MatMul_grad/tuple/group_deps*
T0* 
_output_shapes
:
Љ*?
_class5
31loc:@gradients/ConvNet/dense/MatMul_grad/MatMul_1
}
$gradients/ConvNet/Reshape_grad/ShapeConst*%
valueB"      !   @   *
_output_shapes
:*
dtype0
д
&gradients/ConvNet/Reshape_grad/ReshapeReshape<gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency$gradients/ConvNet/Reshape_grad/Shape*
T0*&
_output_shapes
:!@*
Tshape0
­
:gradients/ConvNet/max_pooling2d_2/MaxPool_grad/MaxPoolGradMaxPoolGradConvNet/conv2d_2/ReluConvNet/max_pooling2d_2/MaxPool&gradients/ConvNet/Reshape_grad/Reshape*
paddingVALID*
data_formatNHWC*
strides
*
T0*&
_output_shapes
:%C@*
ksize

Н
-gradients/ConvNet/conv2d_2/Relu_grad/ReluGradReluGrad:gradients/ConvNet/max_pooling2d_2/MaxPool_grad/MaxPoolGradConvNet/conv2d_2/Relu*
T0*&
_output_shapes
:%C@
­
3gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGradBiasAddGrad-gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad*
T0*
data_formatNHWC*
_output_shapes
:@
І
8gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_depsNoOp.^gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad4^gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad
Љ
@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependencyIdentity-gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad9^gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_deps*
T0*@
_class6
42loc:@gradients/ConvNet/conv2d_2/Relu_grad/ReluGrad*&
_output_shapes
:%C@
Ћ
Bgradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency_1Identity3gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad9^gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/group_deps*F
_class<
:8loc:@gradients/ConvNet/conv2d_2/BiasAdd_grad/BiasAddGrad*
_output_shapes
:@*
T0

1gradients/ConvNet/conv2d_2/convolution_grad/ShapeConst*
_output_shapes
:*
dtype0*%
valueB"   '   E       
ђ
?gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInputConv2DBackpropInput1gradients/ConvNet/conv2d_2/convolution_grad/ShapeConvNet/conv2d_1/kernel/read@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency*
paddingVALID*
data_formatNHWC*
strides
*
use_cudnn_on_gpu(*
T0*&
_output_shapes
:'E 

3gradients/ConvNet/conv2d_2/convolution_grad/Shape_1Const*%
valueB"          @   *
_output_shapes
:*
dtype0
ї
@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilterConv2DBackpropFilterConvNet/max_pooling2d/MaxPool3gradients/ConvNet/conv2d_2/convolution_grad/Shape_1@gradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency*&
_output_shapes
: @*
paddingVALID*
use_cudnn_on_gpu(*
data_formatNHWC*
strides
*
T0
Щ
<gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_depsNoOp@^gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInputA^gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter
е
Dgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependencyIdentity?gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInput=^gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_deps*R
_classH
FDloc:@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropInput*&
_output_shapes
:'E *
T0
й
Fgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency_1Identity@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter=^gradients/ConvNet/conv2d_2/convolution_grad/tuple/group_deps*&
_output_shapes
: @*S
_classI
GEloc:@gradients/ConvNet/conv2d_2/convolution_grad/Conv2DBackpropFilter*
T0
Ц
8gradients/ConvNet/max_pooling2d/MaxPool_grad/MaxPoolGradMaxPoolGradConvNet/conv2d/ReluConvNet/max_pooling2d/MaxPoolDgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency*
ksize
*'
_output_shapes
:N *
T0*
data_formatNHWC*
strides
*
paddingVALID
И
+gradients/ConvNet/conv2d/Relu_grad/ReluGradReluGrad8gradients/ConvNet/max_pooling2d/MaxPool_grad/MaxPoolGradConvNet/conv2d/Relu*
T0*'
_output_shapes
:N 
Љ
1gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGradBiasAddGrad+gradients/ConvNet/conv2d/Relu_grad/ReluGrad*
_output_shapes
: *
T0*
data_formatNHWC
 
6gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_depsNoOp,^gradients/ConvNet/conv2d/Relu_grad/ReluGrad2^gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad
Ђ
>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependencyIdentity+gradients/ConvNet/conv2d/Relu_grad/ReluGrad7^gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_deps*'
_output_shapes
:N *>
_class4
20loc:@gradients/ConvNet/conv2d/Relu_grad/ReluGrad*
T0
Ѓ
@gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency_1Identity1gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad7^gradients/ConvNet/conv2d/BiasAdd_grad/tuple/group_deps*D
_class:
86loc:@gradients/ConvNet/conv2d/BiasAdd_grad/BiasAddGrad*
_output_shapes
: *
T0

/gradients/ConvNet/conv2d/convolution_grad/ShapeConst*%
valueB"   P         *
_output_shapes
:*
dtype0
ы
=gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInputConv2DBackpropInput/gradients/ConvNet/conv2d/convolution_grad/ShapeConvNet/conv2d/kernel/read>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency*
paddingVALID*
data_formatNHWC*
strides
*
use_cudnn_on_gpu(*
T0*'
_output_shapes
:P

1gradients/ConvNet/conv2d/convolution_grad/Shape_1Const*
_output_shapes
:*
dtype0*%
valueB"             
к
>gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilterConv2DBackpropFilterconcat1gradients/ConvNet/conv2d/convolution_grad/Shape_1>gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency*
paddingVALID*
data_formatNHWC*
strides
*
use_cudnn_on_gpu(*
T0*&
_output_shapes
: 
У
:gradients/ConvNet/conv2d/convolution_grad/tuple/group_depsNoOp>^gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput?^gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter
Ю
Bgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependencyIdentity=gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput;^gradients/ConvNet/conv2d/convolution_grad/tuple/group_deps*
T0*P
_classF
DBloc:@gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropInput*'
_output_shapes
:P
б
Dgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependency_1Identity>gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter;^gradients/ConvNet/conv2d/convolution_grad/tuple/group_deps*&
_output_shapes
: *Q
_classG
ECloc:@gradients/ConvNet/conv2d/convolution_grad/Conv2DBackpropFilter*
T0
b
GradientDescent/learning_rateConst*
_output_shapes
: *
dtype0*
valueB
 *
з#<
У
AGradientDescent/update_ConvNet/conv2d/kernel/ApplyGradientDescentApplyGradientDescentConvNet/conv2d/kernelGradientDescent/learning_rateDgradients/ConvNet/conv2d/convolution_grad/tuple/control_dependency_1*&
_output_shapes
: *(
_class
loc:@ConvNet/conv2d/kernel*
T0*
use_locking( 
­
?GradientDescent/update_ConvNet/conv2d/bias/ApplyGradientDescentApplyGradientDescentConvNet/conv2d/biasGradientDescent/learning_rate@gradients/ConvNet/conv2d/BiasAdd_grad/tuple/control_dependency_1*&
_class
loc:@ConvNet/conv2d/bias*
_output_shapes
: *
T0*
use_locking( 
Ы
CGradientDescent/update_ConvNet/conv2d_1/kernel/ApplyGradientDescentApplyGradientDescentConvNet/conv2d_1/kernelGradientDescent/learning_rateFgradients/ConvNet/conv2d_2/convolution_grad/tuple/control_dependency_1**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @*
T0*
use_locking( 
Е
AGradientDescent/update_ConvNet/conv2d_1/bias/ApplyGradientDescentApplyGradientDescentConvNet/conv2d_1/biasGradientDescent/learning_rateBgradients/ConvNet/conv2d_2/BiasAdd_grad/tuple/control_dependency_1*
use_locking( *
T0*
_output_shapes
:@*(
_class
loc:@ConvNet/conv2d_1/bias
Д
@GradientDescent/update_ConvNet/dense/kernel/ApplyGradientDescentApplyGradientDescentConvNet/dense/kernelGradientDescent/learning_rate>gradients/ConvNet/dense/MatMul_grad/tuple/control_dependency_1*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0*
use_locking( 
Љ
>GradientDescent/update_ConvNet/dense/bias/ApplyGradientDescentApplyGradientDescentConvNet/dense/biasGradientDescent/learning_rate?gradients/ConvNet/dense/BiasAdd_grad/tuple/control_dependency_1*
use_locking( *
T0*
_output_shapes
:*%
_class
loc:@ConvNet/dense/bias
К
BGradientDescent/update_ConvNet/dense_1/kernel/ApplyGradientDescentApplyGradientDescentConvNet/dense_1/kernelGradientDescent/learning_rate@gradients/ConvNet/dense_2/MatMul_grad/tuple/control_dependency_1*
use_locking( *
T0*
_output_shapes

:*)
_class
loc:@ConvNet/dense_1/kernel
Б
@GradientDescent/update_ConvNet/dense_1/bias/ApplyGradientDescentApplyGradientDescentConvNet/dense_1/biasGradientDescent/learning_rateAgradients/ConvNet/dense_2/BiasAdd_grad/tuple/control_dependency_1*
_output_shapes
:*'
_class
loc:@ConvNet/dense_1/bias*
T0*
use_locking( 
Г
GradientDescentNoOpB^GradientDescent/update_ConvNet/conv2d/kernel/ApplyGradientDescent@^GradientDescent/update_ConvNet/conv2d/bias/ApplyGradientDescentD^GradientDescent/update_ConvNet/conv2d_1/kernel/ApplyGradientDescentB^GradientDescent/update_ConvNet/conv2d_1/bias/ApplyGradientDescentA^GradientDescent/update_ConvNet/dense/kernel/ApplyGradientDescent?^GradientDescent/update_ConvNet/dense/bias/ApplyGradientDescentC^GradientDescent/update_ConvNet/dense_1/kernel/ApplyGradientDescentA^GradientDescent/update_ConvNet/dense_1/bias/ApplyGradientDescent
P

save/ConstConst*
valueB Bmodel*
_output_shapes
: *
dtype0
к
save/SaveV2/tensor_namesConst*
valueBBConvNet/conv2d/biasBConvNet/conv2d/kernelBConvNet/conv2d_1/biasBConvNet/conv2d_1/kernelBConvNet/dense/biasBConvNet/dense/kernelBConvNet/dense_1/biasBConvNet/dense_1/kernelBmatching_filenamesBmatching_filenames_1Bmatching_filenames_2Bmatching_filenames_3Bmatching_filenames_4Bmatching_filenames_5Bmatching_filenames_6Bmatching_filenames_7Bmatching_filenames_8*
_output_shapes
:*
dtype0

save/SaveV2/shape_and_slicesConst*5
value,B*B B B B B B B B B B B B B B B B B *
_output_shapes
:*
dtype0
ђ
save/SaveV2SaveV2
save/Constsave/SaveV2/tensor_namessave/SaveV2/shape_and_slicesConvNet/conv2d/biasConvNet/conv2d/kernelConvNet/conv2d_1/biasConvNet/conv2d_1/kernelConvNet/dense/biasConvNet/dense/kernelConvNet/dense_1/biasConvNet/dense_1/kernelmatching_filenamesmatching_filenames_1matching_filenames_2matching_filenames_3matching_filenames_4matching_filenames_5matching_filenames_6matching_filenames_7matching_filenames_8*
dtypes
2
}
save/control_dependencyIdentity
save/Const^save/SaveV2*
_class
loc:@save/Const*
_output_shapes
: *
T0
w
save/RestoreV2/tensor_namesConst*(
valueBBConvNet/conv2d/bias*
_output_shapes
:*
dtype0
h
save/RestoreV2/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2	RestoreV2
save/Constsave/RestoreV2/tensor_namessave/RestoreV2/shape_and_slices*
dtypes
2*
_output_shapes
:
А
save/AssignAssignConvNet/conv2d/biassave/RestoreV2*
use_locking(*
validate_shape(*
T0*
_output_shapes
: *&
_class
loc:@ConvNet/conv2d/bias
{
save/RestoreV2_1/tensor_namesConst*
_output_shapes
:*
dtype0**
value!BBConvNet/conv2d/kernel
j
!save/RestoreV2_1/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_1	RestoreV2
save/Constsave/RestoreV2_1/tensor_names!save/RestoreV2_1/shape_and_slices*
dtypes
2*
_output_shapes
:
Ф
save/Assign_1AssignConvNet/conv2d/kernelsave/RestoreV2_1*
use_locking(*
T0*(
_class
loc:@ConvNet/conv2d/kernel*
validate_shape(*&
_output_shapes
: 
{
save/RestoreV2_2/tensor_namesConst**
value!BBConvNet/conv2d_1/bias*
dtype0*
_output_shapes
:
j
!save/RestoreV2_2/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_2	RestoreV2
save/Constsave/RestoreV2_2/tensor_names!save/RestoreV2_2/shape_and_slices*
dtypes
2*
_output_shapes
:
И
save/Assign_2AssignConvNet/conv2d_1/biassave/RestoreV2_2*
use_locking(*
T0*(
_class
loc:@ConvNet/conv2d_1/bias*
validate_shape(*
_output_shapes
:@
}
save/RestoreV2_3/tensor_namesConst*
_output_shapes
:*
dtype0*,
value#B!BConvNet/conv2d_1/kernel
j
!save/RestoreV2_3/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_3	RestoreV2
save/Constsave/RestoreV2_3/tensor_names!save/RestoreV2_3/shape_and_slices*
_output_shapes
:*
dtypes
2
Ш
save/Assign_3AssignConvNet/conv2d_1/kernelsave/RestoreV2_3**
_class 
loc:@ConvNet/conv2d_1/kernel*&
_output_shapes
: @*
T0*
validate_shape(*
use_locking(
x
save/RestoreV2_4/tensor_namesConst*'
valueBBConvNet/dense/bias*
dtype0*
_output_shapes
:
j
!save/RestoreV2_4/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_4	RestoreV2
save/Constsave/RestoreV2_4/tensor_names!save/RestoreV2_4/shape_and_slices*
dtypes
2*
_output_shapes
:
В
save/Assign_4AssignConvNet/dense/biassave/RestoreV2_4*
use_locking(*
validate_shape(*
T0*
_output_shapes
:*%
_class
loc:@ConvNet/dense/bias
z
save/RestoreV2_5/tensor_namesConst*)
value BBConvNet/dense/kernel*
_output_shapes
:*
dtype0
j
!save/RestoreV2_5/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_5	RestoreV2
save/Constsave/RestoreV2_5/tensor_names!save/RestoreV2_5/shape_and_slices*
dtypes
2*
_output_shapes
:
М
save/Assign_5AssignConvNet/dense/kernelsave/RestoreV2_5*'
_class
loc:@ConvNet/dense/kernel* 
_output_shapes
:
Љ*
T0*
validate_shape(*
use_locking(
z
save/RestoreV2_6/tensor_namesConst*
dtype0*
_output_shapes
:*)
value BBConvNet/dense_1/bias
j
!save/RestoreV2_6/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_6	RestoreV2
save/Constsave/RestoreV2_6/tensor_names!save/RestoreV2_6/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_6AssignConvNet/dense_1/biassave/RestoreV2_6*
use_locking(*
T0*'
_class
loc:@ConvNet/dense_1/bias*
validate_shape(*
_output_shapes
:
|
save/RestoreV2_7/tensor_namesConst*
dtype0*
_output_shapes
:*+
value"B BConvNet/dense_1/kernel
j
!save/RestoreV2_7/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_7	RestoreV2
save/Constsave/RestoreV2_7/tensor_names!save/RestoreV2_7/shape_and_slices*
_output_shapes
:*
dtypes
2
О
save/Assign_7AssignConvNet/dense_1/kernelsave/RestoreV2_7*
_output_shapes

:*
validate_shape(*)
_class
loc:@ConvNet/dense_1/kernel*
T0*
use_locking(
x
save/RestoreV2_8/tensor_namesConst*
dtype0*
_output_shapes
:*'
valueBBmatching_filenames
j
!save/RestoreV2_8/shape_and_slicesConst*
valueB
B *
_output_shapes
:*
dtype0

save/RestoreV2_8	RestoreV2
save/Constsave/RestoreV2_8/tensor_names!save/RestoreV2_8/shape_and_slices*
dtypes
2*
_output_shapes
:
А
save/Assign_8Assignmatching_filenamessave/RestoreV2_8*%
_class
loc:@matching_filenames*
_output_shapes
:*
T0*
validate_shape( *
use_locking(
z
save/RestoreV2_9/tensor_namesConst*
dtype0*
_output_shapes
:*)
value BBmatching_filenames_1
j
!save/RestoreV2_9/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_9	RestoreV2
save/Constsave/RestoreV2_9/tensor_names!save/RestoreV2_9/shape_and_slices*
dtypes
2*
_output_shapes
:
Д
save/Assign_9Assignmatching_filenames_1save/RestoreV2_9*
use_locking(*
validate_shape( *
T0*
_output_shapes
:*'
_class
loc:@matching_filenames_1
{
save/RestoreV2_10/tensor_namesConst*
dtype0*
_output_shapes
:*)
value BBmatching_filenames_2
k
"save/RestoreV2_10/shape_and_slicesConst*
valueB
B *
dtype0*
_output_shapes
:

save/RestoreV2_10	RestoreV2
save/Constsave/RestoreV2_10/tensor_names"save/RestoreV2_10/shape_and_slices*
dtypes
2*
_output_shapes
:
Ж
save/Assign_10Assignmatching_filenames_2save/RestoreV2_10*
use_locking(*
T0*'
_class
loc:@matching_filenames_2*
validate_shape( *
_output_shapes
:
{
save/RestoreV2_11/tensor_namesConst*)
value BBmatching_filenames_3*
_output_shapes
:*
dtype0
k
"save/RestoreV2_11/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_11	RestoreV2
save/Constsave/RestoreV2_11/tensor_names"save/RestoreV2_11/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_11Assignmatching_filenames_3save/RestoreV2_11*
use_locking(*
T0*'
_class
loc:@matching_filenames_3*
validate_shape( *
_output_shapes
:
{
save/RestoreV2_12/tensor_namesConst*
_output_shapes
:*
dtype0*)
value BBmatching_filenames_4
k
"save/RestoreV2_12/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_12	RestoreV2
save/Constsave/RestoreV2_12/tensor_names"save/RestoreV2_12/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_12Assignmatching_filenames_4save/RestoreV2_12*'
_class
loc:@matching_filenames_4*
_output_shapes
:*
T0*
validate_shape( *
use_locking(
{
save/RestoreV2_13/tensor_namesConst*)
value BBmatching_filenames_5*
_output_shapes
:*
dtype0
k
"save/RestoreV2_13/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_13	RestoreV2
save/Constsave/RestoreV2_13/tensor_names"save/RestoreV2_13/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_13Assignmatching_filenames_5save/RestoreV2_13*'
_class
loc:@matching_filenames_5*
_output_shapes
:*
T0*
validate_shape( *
use_locking(
{
save/RestoreV2_14/tensor_namesConst*
_output_shapes
:*
dtype0*)
value BBmatching_filenames_6
k
"save/RestoreV2_14/shape_and_slicesConst*
_output_shapes
:*
dtype0*
valueB
B 

save/RestoreV2_14	RestoreV2
save/Constsave/RestoreV2_14/tensor_names"save/RestoreV2_14/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_14Assignmatching_filenames_6save/RestoreV2_14*
use_locking(*
T0*'
_class
loc:@matching_filenames_6*
validate_shape( *
_output_shapes
:
{
save/RestoreV2_15/tensor_namesConst*)
value BBmatching_filenames_7*
_output_shapes
:*
dtype0
k
"save/RestoreV2_15/shape_and_slicesConst*
valueB
B *
_output_shapes
:*
dtype0

save/RestoreV2_15	RestoreV2
save/Constsave/RestoreV2_15/tensor_names"save/RestoreV2_15/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_15Assignmatching_filenames_7save/RestoreV2_15*
_output_shapes
:*
validate_shape( *'
_class
loc:@matching_filenames_7*
T0*
use_locking(
{
save/RestoreV2_16/tensor_namesConst*)
value BBmatching_filenames_8*
_output_shapes
:*
dtype0
k
"save/RestoreV2_16/shape_and_slicesConst*
dtype0*
_output_shapes
:*
valueB
B 

save/RestoreV2_16	RestoreV2
save/Constsave/RestoreV2_16/tensor_names"save/RestoreV2_16/shape_and_slices*
_output_shapes
:*
dtypes
2
Ж
save/Assign_16Assignmatching_filenames_8save/RestoreV2_16*
_output_shapes
:*
validate_shape( *'
_class
loc:@matching_filenames_8*
T0*
use_locking(
­
save/restore_allNoOp^save/Assign^save/Assign_1^save/Assign_2^save/Assign_3^save/Assign_4^save/Assign_5^save/Assign_6^save/Assign_7^save/Assign_8^save/Assign_9^save/Assign_10^save/Assign_11^save/Assign_12^save/Assign_13^save/Assign_14^save/Assign_15^save/Assign_16""Ћ
	variables
L
matching_filenames:0matching_filenames/Assignmatching_filenames/read:0
R
matching_filenames_1:0matching_filenames_1/Assignmatching_filenames_1/read:0
R
matching_filenames_2:0matching_filenames_2/Assignmatching_filenames_2/read:0
R
matching_filenames_3:0matching_filenames_3/Assignmatching_filenames_3/read:0
R
matching_filenames_4:0matching_filenames_4/Assignmatching_filenames_4/read:0
R
matching_filenames_5:0matching_filenames_5/Assignmatching_filenames_5/read:0
R
matching_filenames_6:0matching_filenames_6/Assignmatching_filenames_6/read:0
R
matching_filenames_7:0matching_filenames_7/Assignmatching_filenames_7/read:0
R
matching_filenames_8:0matching_filenames_8/Assignmatching_filenames_8/read:0
U
ConvNet/conv2d/kernel:0ConvNet/conv2d/kernel/AssignConvNet/conv2d/kernel/read:0
O
ConvNet/conv2d/bias:0ConvNet/conv2d/bias/AssignConvNet/conv2d/bias/read:0
[
ConvNet/conv2d_1/kernel:0ConvNet/conv2d_1/kernel/AssignConvNet/conv2d_1/kernel/read:0
U
ConvNet/conv2d_1/bias:0ConvNet/conv2d_1/bias/AssignConvNet/conv2d_1/bias/read:0
R
ConvNet/dense/kernel:0ConvNet/dense/kernel/AssignConvNet/dense/kernel/read:0
L
ConvNet/dense/bias:0ConvNet/dense/bias/AssignConvNet/dense/bias/read:0
X
ConvNet/dense_1/kernel:0ConvNet/dense_1/kernel/AssignConvNet/dense_1/kernel/read:0
R
ConvNet/dense_1/bias:0ConvNet/dense_1/bias/AssignConvNet/dense_1/bias/read:0"
	summaries

$input_producer/fraction_of_32_full:0
+shuffle_batch/fraction_over_10_of_12_full:0
&input_producer_1/fraction_of_32_full:0
-shuffle_batch_1/fraction_over_10_of_12_full:0
&input_producer_2/fraction_of_32_full:0
-shuffle_batch_2/fraction_over_10_of_12_full:0
&input_producer_3/fraction_of_32_full:0
-shuffle_batch_3/fraction_over_10_of_12_full:0
&input_producer_4/fraction_of_32_full:0
-shuffle_batch_4/fraction_over_10_of_12_full:0
&input_producer_5/fraction_of_32_full:0
-shuffle_batch_5/fraction_over_10_of_12_full:0
&input_producer_6/fraction_of_32_full:0
-shuffle_batch_6/fraction_over_10_of_12_full:0
&input_producer_7/fraction_of_32_full:0
-shuffle_batch_7/fraction_over_10_of_12_full:0
&input_producer_8/fraction_of_32_full:0
-shuffle_batch_8/fraction_over_10_of_12_full:0"Ч
trainable_variablesЏЌ
U
ConvNet/conv2d/kernel:0ConvNet/conv2d/kernel/AssignConvNet/conv2d/kernel/read:0
O
ConvNet/conv2d/bias:0ConvNet/conv2d/bias/AssignConvNet/conv2d/bias/read:0
[
ConvNet/conv2d_1/kernel:0ConvNet/conv2d_1/kernel/AssignConvNet/conv2d_1/kernel/read:0
U
ConvNet/conv2d_1/bias:0ConvNet/conv2d_1/bias/AssignConvNet/conv2d_1/bias/read:0
R
ConvNet/dense/kernel:0ConvNet/dense/kernel/AssignConvNet/dense/kernel/read:0
L
ConvNet/dense/bias:0ConvNet/dense/bias/AssignConvNet/dense/bias/read:0
X
ConvNet/dense_1/kernel:0ConvNet/dense_1/kernel/AssignConvNet/dense_1/kernel/read:0
R
ConvNet/dense_1/bias:0ConvNet/dense_1/bias/AssignConvNet/dense_1/bias/read:0"
train_op

GradientDescent"еB
cond_contextФBСB
М
shuffle_batch/cond/cond_textshuffle_batch/cond/pred_id:0shuffle_batch/cond/switch_t:0 *м
shuffle_batch/Const:0
'shuffle_batch/cond/control_dependency:0
shuffle_batch/cond/pred_id:0
8shuffle_batch/cond/random_shuffle_queue_enqueue/Switch:1
:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1:1
:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch/cond/switch_t:0
$shuffle_batch/random_shuffle_queue:0
sub_6:0`
$shuffle_batch/random_shuffle_queue:08shuffle_batch/cond/random_shuffle_queue_enqueue/Switch:1S
shuffle_batch/Const:0:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_2:1E
sub_6:0:shuffle_batch/cond/random_shuffle_queue_enqueue/Switch_1:1
Ч
shuffle_batch/cond/cond_text_1shuffle_batch/cond/pred_id:0shuffle_batch/cond/switch_f:0*h
)shuffle_batch/cond/control_dependency_1:0
shuffle_batch/cond/pred_id:0
shuffle_batch/cond/switch_f:0
о
shuffle_batch_1/cond/cond_textshuffle_batch_1/cond/pred_id:0shuffle_batch_1/cond/switch_t:0 *ј
shuffle_batch_1/Const:0
)shuffle_batch_1/cond/control_dependency:0
shuffle_batch_1/cond/pred_id:0
:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_1/cond/switch_t:0
&shuffle_batch_1/random_shuffle_queue:0
sub_13:0d
&shuffle_batch_1/random_shuffle_queue:0:shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch:1H
sub_13:0<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_1:1W
shuffle_batch_1/Const:0<shuffle_batch_1/cond/random_shuffle_queue_enqueue/Switch_2:1
г
 shuffle_batch_1/cond/cond_text_1shuffle_batch_1/cond/pred_id:0shuffle_batch_1/cond/switch_f:0*n
+shuffle_batch_1/cond/control_dependency_1:0
shuffle_batch_1/cond/pred_id:0
shuffle_batch_1/cond/switch_f:0
о
shuffle_batch_2/cond/cond_textshuffle_batch_2/cond/pred_id:0shuffle_batch_2/cond/switch_t:0 *ј
shuffle_batch_2/Const:0
)shuffle_batch_2/cond/control_dependency:0
shuffle_batch_2/cond/pred_id:0
:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_2/cond/switch_t:0
&shuffle_batch_2/random_shuffle_queue:0
sub_20:0d
&shuffle_batch_2/random_shuffle_queue:0:shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch:1H
sub_20:0<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_1:1W
shuffle_batch_2/Const:0<shuffle_batch_2/cond/random_shuffle_queue_enqueue/Switch_2:1
г
 shuffle_batch_2/cond/cond_text_1shuffle_batch_2/cond/pred_id:0shuffle_batch_2/cond/switch_f:0*n
+shuffle_batch_2/cond/control_dependency_1:0
shuffle_batch_2/cond/pred_id:0
shuffle_batch_2/cond/switch_f:0
о
shuffle_batch_3/cond/cond_textshuffle_batch_3/cond/pred_id:0shuffle_batch_3/cond/switch_t:0 *ј
shuffle_batch_3/Const:0
)shuffle_batch_3/cond/control_dependency:0
shuffle_batch_3/cond/pred_id:0
:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_3/cond/switch_t:0
&shuffle_batch_3/random_shuffle_queue:0
sub_27:0H
sub_27:0<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_1:1d
&shuffle_batch_3/random_shuffle_queue:0:shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch:1W
shuffle_batch_3/Const:0<shuffle_batch_3/cond/random_shuffle_queue_enqueue/Switch_2:1
г
 shuffle_batch_3/cond/cond_text_1shuffle_batch_3/cond/pred_id:0shuffle_batch_3/cond/switch_f:0*n
+shuffle_batch_3/cond/control_dependency_1:0
shuffle_batch_3/cond/pred_id:0
shuffle_batch_3/cond/switch_f:0
о
shuffle_batch_4/cond/cond_textshuffle_batch_4/cond/pred_id:0shuffle_batch_4/cond/switch_t:0 *ј
shuffle_batch_4/Const:0
)shuffle_batch_4/cond/control_dependency:0
shuffle_batch_4/cond/pred_id:0
:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_4/cond/switch_t:0
&shuffle_batch_4/random_shuffle_queue:0
sub_34:0W
shuffle_batch_4/Const:0<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_2:1H
sub_34:0<shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch_1:1d
&shuffle_batch_4/random_shuffle_queue:0:shuffle_batch_4/cond/random_shuffle_queue_enqueue/Switch:1
г
 shuffle_batch_4/cond/cond_text_1shuffle_batch_4/cond/pred_id:0shuffle_batch_4/cond/switch_f:0*n
+shuffle_batch_4/cond/control_dependency_1:0
shuffle_batch_4/cond/pred_id:0
shuffle_batch_4/cond/switch_f:0
о
shuffle_batch_5/cond/cond_textshuffle_batch_5/cond/pred_id:0shuffle_batch_5/cond/switch_t:0 *ј
shuffle_batch_5/Const:0
)shuffle_batch_5/cond/control_dependency:0
shuffle_batch_5/cond/pred_id:0
:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_5/cond/switch_t:0
&shuffle_batch_5/random_shuffle_queue:0
sub_41:0d
&shuffle_batch_5/random_shuffle_queue:0:shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch:1W
shuffle_batch_5/Const:0<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_2:1H
sub_41:0<shuffle_batch_5/cond/random_shuffle_queue_enqueue/Switch_1:1
г
 shuffle_batch_5/cond/cond_text_1shuffle_batch_5/cond/pred_id:0shuffle_batch_5/cond/switch_f:0*n
+shuffle_batch_5/cond/control_dependency_1:0
shuffle_batch_5/cond/pred_id:0
shuffle_batch_5/cond/switch_f:0
о
shuffle_batch_6/cond/cond_textshuffle_batch_6/cond/pred_id:0shuffle_batch_6/cond/switch_t:0 *ј
shuffle_batch_6/Const:0
)shuffle_batch_6/cond/control_dependency:0
shuffle_batch_6/cond/pred_id:0
:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_6/cond/switch_t:0
&shuffle_batch_6/random_shuffle_queue:0
sub_48:0W
shuffle_batch_6/Const:0<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_2:1d
&shuffle_batch_6/random_shuffle_queue:0:shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch:1H
sub_48:0<shuffle_batch_6/cond/random_shuffle_queue_enqueue/Switch_1:1
г
 shuffle_batch_6/cond/cond_text_1shuffle_batch_6/cond/pred_id:0shuffle_batch_6/cond/switch_f:0*n
+shuffle_batch_6/cond/control_dependency_1:0
shuffle_batch_6/cond/pred_id:0
shuffle_batch_6/cond/switch_f:0
о
shuffle_batch_7/cond/cond_textshuffle_batch_7/cond/pred_id:0shuffle_batch_7/cond/switch_t:0 *ј
shuffle_batch_7/Const:0
)shuffle_batch_7/cond/control_dependency:0
shuffle_batch_7/cond/pred_id:0
:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_7/cond/switch_t:0
&shuffle_batch_7/random_shuffle_queue:0
sub_55:0W
shuffle_batch_7/Const:0<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_2:1H
sub_55:0<shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch_1:1d
&shuffle_batch_7/random_shuffle_queue:0:shuffle_batch_7/cond/random_shuffle_queue_enqueue/Switch:1
г
 shuffle_batch_7/cond/cond_text_1shuffle_batch_7/cond/pred_id:0shuffle_batch_7/cond/switch_f:0*n
+shuffle_batch_7/cond/control_dependency_1:0
shuffle_batch_7/cond/pred_id:0
shuffle_batch_7/cond/switch_f:0
о
shuffle_batch_8/cond/cond_textshuffle_batch_8/cond/pred_id:0shuffle_batch_8/cond/switch_t:0 *ј
shuffle_batch_8/Const:0
)shuffle_batch_8/cond/control_dependency:0
shuffle_batch_8/cond/pred_id:0
:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch:1
<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1:1
<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2:1
shuffle_batch_8/cond/switch_t:0
&shuffle_batch_8/random_shuffle_queue:0
sub_62:0W
shuffle_batch_8/Const:0<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_2:1H
sub_62:0<shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch_1:1d
&shuffle_batch_8/random_shuffle_queue:0:shuffle_batch_8/cond/random_shuffle_queue_enqueue/Switch:1
г
 shuffle_batch_8/cond/cond_text_1shuffle_batch_8/cond/pred_id:0shuffle_batch_8/cond/switch_f:0*n
+shuffle_batch_8/cond/control_dependency_1:0
shuffle_batch_8/cond/pred_id:0
shuffle_batch_8/cond/switch_f:0"Ж
queue_runnersЄЁ

input_producer)input_producer/input_producer_EnqueueMany#input_producer/input_producer_Close"%input_producer/input_producer_Close_1*

"shuffle_batch/random_shuffle_queueshuffle_batch/cond/Merge:0(shuffle_batch/random_shuffle_queue_Close"*shuffle_batch/random_shuffle_queue_Close_1*

input_producer_1-input_producer_1/input_producer_1_EnqueueMany'input_producer_1/input_producer_1_Close")input_producer_1/input_producer_1_Close_1*
Ё
$shuffle_batch_1/random_shuffle_queueshuffle_batch_1/cond/Merge:0*shuffle_batch_1/random_shuffle_queue_Close",shuffle_batch_1/random_shuffle_queue_Close_1*

input_producer_2-input_producer_2/input_producer_2_EnqueueMany'input_producer_2/input_producer_2_Close")input_producer_2/input_producer_2_Close_1*
Ё
$shuffle_batch_2/random_shuffle_queueshuffle_batch_2/cond/Merge:0*shuffle_batch_2/random_shuffle_queue_Close",shuffle_batch_2/random_shuffle_queue_Close_1*

input_producer_3-input_producer_3/input_producer_3_EnqueueMany'input_producer_3/input_producer_3_Close")input_producer_3/input_producer_3_Close_1*
Ё
$shuffle_batch_3/random_shuffle_queueshuffle_batch_3/cond/Merge:0*shuffle_batch_3/random_shuffle_queue_Close",shuffle_batch_3/random_shuffle_queue_Close_1*

input_producer_4-input_producer_4/input_producer_4_EnqueueMany'input_producer_4/input_producer_4_Close")input_producer_4/input_producer_4_Close_1*
Ё
$shuffle_batch_4/random_shuffle_queueshuffle_batch_4/cond/Merge:0*shuffle_batch_4/random_shuffle_queue_Close",shuffle_batch_4/random_shuffle_queue_Close_1*

input_producer_5-input_producer_5/input_producer_5_EnqueueMany'input_producer_5/input_producer_5_Close")input_producer_5/input_producer_5_Close_1*
Ё
$shuffle_batch_5/random_shuffle_queueshuffle_batch_5/cond/Merge:0*shuffle_batch_5/random_shuffle_queue_Close",shuffle_batch_5/random_shuffle_queue_Close_1*

input_producer_6-input_producer_6/input_producer_6_EnqueueMany'input_producer_6/input_producer_6_Close")input_producer_6/input_producer_6_Close_1*
Ё
$shuffle_batch_6/random_shuffle_queueshuffle_batch_6/cond/Merge:0*shuffle_batch_6/random_shuffle_queue_Close",shuffle_batch_6/random_shuffle_queue_Close_1*

input_producer_7-input_producer_7/input_producer_7_EnqueueMany'input_producer_7/input_producer_7_Close")input_producer_7/input_producer_7_Close_1*
Ё
$shuffle_batch_7/random_shuffle_queueshuffle_batch_7/cond/Merge:0*shuffle_batch_7/random_shuffle_queue_Close",shuffle_batch_7/random_shuffle_queue_Close_1*

input_producer_8-input_producer_8/input_producer_8_EnqueueMany'input_producer_8/input_producer_8_Close")input_producer_8/input_producer_8_Close_1*
Ё
$shuffle_batch_8/random_shuffle_queueshuffle_batch_8/cond/Merge:0*shuffle_batch_8/random_shuffle_queue_Close",shuffle_batch_8/random_shuffle_queue_Close_1*хAwА