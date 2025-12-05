using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_reserved_instance_offering Terraform data source.
/// Retrieves information about a aws_rds_reserved_instance_offering.
/// </summary>
public partial class AwsRdsReservedInstanceOfferingDataSource(string name) : TerraformDataSource("aws_rds_reserved_instance_offering", name)
{
    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceClass is required")]
    public required TerraformValue<string> DbInstanceClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("db_instance_class");
        set => SetArgument("db_instance_class", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => GetRequiredArgument<TerraformValue<double>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiAz is required")]
    public required TerraformValue<bool> MultiAz
    {
        get => GetRequiredArgument<TerraformValue<bool>>("multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    public required TerraformValue<string> OfferingType
    {
        get => GetRequiredArgument<TerraformValue<string>>("offering_type");
        set => SetArgument("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    public required TerraformValue<string> ProductDescription
    {
        get => GetRequiredArgument<TerraformValue<string>>("product_description");
        set => SetArgument("product_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformValue<string> CurrencyCode
        => CreateReference("currency_code");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
        => CreateReference("fixed_price");

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformValue<string> OfferingId
        => CreateReference("offering_id");

}
