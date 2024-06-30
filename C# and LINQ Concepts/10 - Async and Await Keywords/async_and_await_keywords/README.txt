
In C#, the `async` and `await` keywords are used to handle asynchronous programming, making it easier to
write code that performs tasks without blocking the main thread.

`async` Keyword - Returns type `Task`, `Task<Result>`, or `void`.

`await` Keyword - Used within an `async` method to pause execution until a task completes.

Benefits :

Improved Responsiveness: Keep applications responsive, especially in UI applications.
Non-blocking: Frees up the main thread for other tasks while waiting for asynchronous operations.
Code Simplicity: Makes asynchronous code easier to read and maintain compared to traditional call-back
				 approaches.