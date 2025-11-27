using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for geo_match_constraint in AwsWafregionalGeoMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafregionalGeoMatchSetGeoMatchConstraintBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_wafregional_geo_match_set Terraform resource.
/// Manages a aws_wafregional_geo_match_set resource.
/// </summary>
public partial class AwsWafregionalGeoMatchSet(string name) : TerraformResource("aws_wafregional_geo_match_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// GeoMatchConstraint block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafregionalGeoMatchSetGeoMatchConstraintBlock>? GeoMatchConstraint
    {
        get => GetArgument<TerraformSet<AwsWafregionalGeoMatchSetGeoMatchConstraintBlock>>("geo_match_constraint");
        set => SetArgument("geo_match_constraint", value);
    }

}
