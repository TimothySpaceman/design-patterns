# Not Diia

This project's purpose is to examine and practice programming principles.
Here's an overview of all applied principles and some additional explanations.

### 1. DRY

As an example of the DRY principle, we can use this part: indexes of the next and previous documents in the document
container.
There are simple formulas for calculating the neighbors of some index, and these operations are performed several times.
According to the DRY (Don't Repeat Yourself) principle, we've extracted these operations into corresponding methods
(see [this part](./NotDiia.cs#L13-L14)).

### 2. Composition Over Inheritance

When we talk about different types of documents initially comes to mind the idea of creating one common parent class
from which all types of documents would inherit.
This parent class could implement all the common properties and behaviors for documents. However, according to the
Composition Over Inheritance principle, a different approach was applied:
the common information for all documents was placed in a separate class - [Personal Info](./PersonalInfo.cs).
Also, perhaps it would be a good idea to put [the series and the document number](./IDocument.cs) in a separate(maybe
even parent) class,
but I've decided not to do that. That way, properties such as personal information about the owner of a document
are implemented by classes not through inheritance, but through composition, [example](./Passport.cs#L5).

### 3. SOLID (Single Responsibility)

Let's take a QR Generation as an example. If we implement it directly in the document classes, it would be a second role
for them. So, we'll place the generation process in the [corresponding class](./QRCodeGenerator.cs).
That way, our document classes still have only one main purpose: representing document information.

### 4. SOLID (Liskov Substitution)

For example, we have an [IDocument interface](./IDocument.cs). Let's say that it stands for some other business logic,
not for displaying documents.
And there's also an [IDisplayableDocument interface](./IDisplayableDocument.cs), used for displaying documents.
And because it's inherited from the IDocument interface, we can use all the classes that implement it, as IDocument.

### 5. SOLID (Interface Segregation)

Not all the documents have a photo or QR Code support. That's why these behaviors and properties are not required by the
IDisplayableDocument interface
but are extracted to other interfaces instead (see [IPhotographable](IPhotographable.cs)
and [IQRCodeGeneratable](./IQRСodeGeneratable.cs)).

### 6. SOLID (Dependency Inversion)

Honestly, I'm not sure how to implement it here, but that's what i think about it:
We have a document container - [NotDiia](./NotDiia.cs). And we have some common behaviors for the documents.
Instead of forcing external classes to directly call the CurrentDocument, this class provides
its [corresponding methods](./NotDiia.cs#L69-L73)
and checks if the current document implements this behavior.

### 7. Program to Interfaces not Implementations

Development of this project has started from the interfaces. That way we've got all the functionality our classes need
to provide,
even not knowing exactly HOW they will implement this functionality.

### P.S.

Also, there are a lot of possible improvements. For example, all of the methods in documents can return a string,
and not call Console methods directly. It'll make these classes more universal in terms of using different client types.

Not ashamed to admit that this lab work was confusing and a bit difficult, and I'm not pleased with this level of
planning
and architecture skills, so I will be very thankful for any good remarks, advice, etc.

Stay healthy!

### Rehenel Timothy, VT-22-2