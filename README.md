# Unexpected Mutability with References in F#

This example demonstrates a common source of confusion in F# when working with mutable variables and references. The core issue lies in the distinction between using the `&` operator to obtain a reference to a mutable variable and using the `ref` keyword to create a mutable reference cell.

## Problem
The provided code snippets highlight an unexpected behavior concerning the mutability of variables when combined with references.  The seemingly small difference in how references are created can lead to significantly different behavior regarding mutable variable updates.

## Solution
The solution clarifies the distinctions between the two reference creation methods and explains how they influence mutable variable updates.

## Reproduction
To reproduce the issue, simply compile and run the `bug.fs` file. The output will demonstrate the unexpected result compared to expectations.

## Note
Understanding the nuances of mutable variables and reference handling is critical in writing reliable and predictable F# code. 