using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for size_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsWafSizeConstraintSetSizeConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformProperty<string> ComparisonOperator
    {
        get => GetRequiredProperty<TerraformProperty<string>>("comparison_operator");
        set => WithProperty("comparison_operator", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        get => GetRequiredProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformProperty<string> TextTransformation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("text_transformation");
        set => WithProperty("text_transformation", value);
    }

}

/// <summary>
/// Manages a aws_waf_size_constraint_set resource.
/// </summary>
public class AwsWafSizeConstraintSet : TerraformResource
{
    public AwsWafSizeConstraintSet(string name) : base("aws_waf_size_constraint_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for size_constraints.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafSizeConstraintSetSizeConstraintsBlock>? SizeConstraints
    {
        get => GetProperty<HashSet<AwsWafSizeConstraintSetSizeConstraintsBlock>>("size_constraints");
        set => this.WithProperty("size_constraints", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
