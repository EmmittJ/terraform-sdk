using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for size_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalSizeConstraintSetSizeConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformProperty<string> ComparisonOperator
    {
        get => GetProperty<TerraformProperty<string>>("comparison_operator");
        set => WithProperty("comparison_operator", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformProperty<string> TextTransformation
    {
        get => GetProperty<TerraformProperty<string>>("text_transformation");
        set => WithProperty("text_transformation", value);
    }

}

/// <summary>
/// Manages a aws_wafregional_size_constraint_set resource.
/// </summary>
public class AwsWafregionalSizeConstraintSet : TerraformResource
{
    public AwsWafregionalSizeConstraintSet(string name) : base("aws_wafregional_size_constraint_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for size_constraints.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalSizeConstraintSetSizeConstraintsBlock>? SizeConstraints
    {
        get => GetProperty<HashSet<AwsWafregionalSizeConstraintSetSizeConstraintsBlock>>("size_constraints");
        set => this.WithProperty("size_constraints", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
