using System.ComponentModel.DataAnnotations;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provides validation functionality for Terraform constructs using Data Annotations.
/// </summary>
public static class TerraformValidator
{
    /// <summary>
    /// Validates a Terraform construct using Data Annotations attributes.
    /// </summary>
    /// <param name="construct">The construct to validate.</param>
    /// <returns>A validation result containing any errors found.</returns>
    public static ValidationResult Validate(TerraformBlock construct)
    {
        ArgumentNullException.ThrowIfNull(construct);

        var errors = new List<ValidationError>();

        // Validate using Data Annotations
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(construct);
        var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

        bool isValid = Validator.TryValidateObject(
            construct,
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
                construct,
                propertyName));
        }

        return errors.Count > 0
            ? new ValidationResult(errors)
            : ValidationResult.Success();
    }

    /// <summary>
    /// Validates a Terraform construct and throws an exception if validation fails.
    /// </summary>
    /// <param name="construct">The construct to validate.</param>
    /// <exception cref="TerraformValidationException">Thrown when validation fails.</exception>
    public static void ValidateAndThrow(TerraformBlock construct)
    {
        var result = Validate(construct);

        if (!result.IsValid)
        {
            throw new TerraformValidationException(result);
        }
    }

    /// <summary>
    /// Validates multiple Terraform constructs.
    /// </summary>
    /// <param name="constructs">The constructs to validate.</param>
    /// <returns>A validation result containing all errors found across all constructs.</returns>
    public static ValidationResult ValidateMany(IEnumerable<TerraformBlock> constructs)
    {
        ArgumentNullException.ThrowIfNull(constructs);

        var allErrors = new List<ValidationError>();

        foreach (var construct in constructs)
        {
            var result = Validate(construct);
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
    /// <param name="construct">The construct containing the property.</param>
    /// <param name="validationAttributes">The validation attributes to apply.</param>
    /// <returns>A validation result for the property.</returns>
    public static ValidationResult ValidateProperty(
        object? value,
        string propertyName,
        TerraformBlock construct,
        IEnumerable<ValidationAttribute> validationAttributes)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        ArgumentNullException.ThrowIfNull(construct);
        ArgumentNullException.ThrowIfNull(validationAttributes);

        var errors = new List<ValidationError>();
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(construct)
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
                    construct,
                    propertyName));
            }
        }

        return errors.Count > 0
            ? new ValidationResult(errors)
            : ValidationResult.Success();
    }
}
