using System.ComponentModel.DataAnnotations;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provides validation functionality for Terraform blocks using Data Annotations.
/// </summary>
public static class TerraformValidator
{
    /// <summary>
    /// Validates a Terraform block using Data Annotations attributes.
    /// </summary>
    /// <param name="block">The block to validate.</param>
    /// <returns>A validation result containing any errors found.</returns>
    public static ValidationResult Validate(TerraformBlock block)
    {
        ArgumentNullException.ThrowIfNull(block);

        var errors = new List<ValidationError>();

        // Validate meta-argument constraints first
        ValidateMetaArguments(block, errors);

        // Validate using Data Annotations
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(block);
        var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

        bool isValid = Validator.TryValidateObject(
            block,
            validationContext,
            validationResults,
            validateAllProperties: true);

        // Convert Data Annotations validation results to our ValidationError format
        foreach (var validationResult in validationResults)
        {
            var propertyName = validationResult.MemberNames.FirstOrDefault();
            errors.Add(new ValidationError(
                validationResult.ErrorMessage ?? "Validation failed",
                ValidationSeverity.Error,
                block,
                propertyName));
        }

        return errors.Count > 0
            ? new ValidationResult(errors)
            : ValidationResult.Success();
    }

    /// <summary>
    /// Validates meta-argument constraints (e.g., count and for_each are mutually exclusive).
    /// </summary>
    private static void ValidateMetaArguments(TerraformBlock block, List<ValidationError> errors)
    {
        // Check if block has both count and for_each set
        if (block is ITerraformHasCount hasCount && block is ITerraformHasForEach hasForEach)
        {
            if (hasCount.Count != null && hasForEach.ForEach != null)
            {
                errors.Add(new ValidationError(
                    $"Cannot use both 'count' and 'for_each' meta-arguments on {block.GetType().Name}. They are mutually exclusive.",
                    ValidationSeverity.Error,
                    block,
                    "meta-arguments"));
            }
        }
    }

    /// <summary>
    /// Validates a Terraform block and throws an exception if validation fails.
    /// </summary>
    /// <param name="block">The block to validate.</param>
    /// <exception cref="TerraformValidationException">Thrown when validation fails.</exception>
    public static void ValidateAndThrow(TerraformBlock block)
    {
        var result = Validate(block);

        if (!result.IsValid)
        {
            throw new TerraformValidationException(result);
        }
    }

    /// <summary>
    /// Validates multiple Terraform blocks.
    /// </summary>
    /// <param name="blocks">The blocks to validate.</param>
    /// <returns>A validation result containing all errors found across all blocks.</returns>
    public static ValidationResult ValidateMany(IEnumerable<TerraformBlock> blocks)
    {
        ArgumentNullException.ThrowIfNull(blocks);

        var allErrors = new List<ValidationError>();

        foreach (var block in blocks)
        {
            var result = Validate(block);
            allErrors.AddRange(result.Errors);
        }

        return allErrors.Count > 0
            ? new ValidationResult(allErrors)
            : ValidationResult.Success();
    }

    /// <summary>
    /// Validates a specific property value using Data Annotations.
    /// </summary>
    /// <param name="value">The value to validate.</param>
    /// <param name="propertyName">The name of the property being validated.</param>
    /// <param name="block">The block containing the property.</param>
    /// <param name="validationAttributes">The validation attributes to apply.</param>
    /// <returns>A validation result for the property.</returns>
    public static ValidationResult ValidateProperty(
        object? value,
        string propertyName,
        TerraformBlock block,
        IEnumerable<ValidationAttribute> validationAttributes)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        ArgumentNullException.ThrowIfNull(block);
        ArgumentNullException.ThrowIfNull(validationAttributes);

        var errors = new List<ValidationError>();
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(block)
        {
            MemberName = propertyName
        };

        foreach (var attribute in validationAttributes)
        {
            var validationResult = attribute.GetValidationResult(value, validationContext);

            if (validationResult != System.ComponentModel.DataAnnotations.ValidationResult.Success
                && validationResult != null)
            {
                errors.Add(new ValidationError(
                    validationResult.ErrorMessage ?? "Validation failed",
                    ValidationSeverity.Error,
                    block,
                    propertyName));
            }
        }

        return errors.Count > 0
            ? new ValidationResult(errors)
            : ValidationResult.Success();
    }
}
