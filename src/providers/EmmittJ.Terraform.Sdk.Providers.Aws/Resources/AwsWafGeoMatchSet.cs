using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for geo_match_constraint in AwsWafGeoMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafGeoMatchSetGeoMatchConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_match_constraint";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_waf_geo_match_set Terraform resource.
/// Manages a aws_waf_geo_match_set resource.
/// </summary>
public partial class AwsWafGeoMatchSet(string name) : TerraformResource("aws_waf_geo_match_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// GeoMatchConstraint block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafGeoMatchSetGeoMatchConstraintBlock>? GeoMatchConstraint
    {
        get => GetArgument<TerraformSet<AwsWafGeoMatchSetGeoMatchConstraintBlock>>("geo_match_constraint");
        set => SetArgument("geo_match_constraint", value);
    }

}
