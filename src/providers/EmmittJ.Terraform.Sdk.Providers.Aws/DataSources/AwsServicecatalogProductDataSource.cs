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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    public TerraformValue<string> Distributor
    {
        get => new TerraformReference<string>(this, "distributor");
    }

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformValue<bool> HasDefaultPath
    {
        get => new TerraformReference<bool>(this, "has_default_path");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    public TerraformValue<string> SupportDescription
    {
        get => new TerraformReference<string>(this, "support_description");
    }

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public TerraformValue<string> SupportEmail
    {
        get => new TerraformReference<string>(this, "support_email");
    }

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public TerraformValue<string> SupportUrl
    {
        get => new TerraformReference<string>(this, "support_url");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProductDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProductDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
