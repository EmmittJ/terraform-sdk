using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogProductDataSource.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_product Terraform data source.
/// Retrieves information about a aws_servicecatalog_product.
/// </summary>
public partial class AwsServicecatalogProductDataSource(string name) : TerraformDataSource("aws_servicecatalog_product", name)
{
    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformValue<string>? AcceptLanguage
    {
        get => GetArgument<TerraformValue<string>>("accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    public TerraformValue<string> Distributor
        => AsReference("distributor");

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformValue<bool> HasDefaultPath
        => AsReference("has_default_path");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    public TerraformValue<string> SupportDescription
        => AsReference("support_description");

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public TerraformValue<string> SupportEmail
        => AsReference("support_email");

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public TerraformValue<string> SupportUrl
        => AsReference("support_url");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProductDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProductDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
