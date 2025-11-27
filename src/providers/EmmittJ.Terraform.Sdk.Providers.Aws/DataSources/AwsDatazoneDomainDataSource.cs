using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_datazone_domain Terraform data source.
/// Retrieves information about a aws_datazone_domain.
/// </summary>
public partial class AwsDatazoneDomainDataSource(string name) : TerraformDataSource("aws_datazone_domain", name)
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
    public TerraformValue<string> Name
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    public TerraformValue<string> DomainVersion
    {
        get => new TerraformReference<string>(this, "domain_version");
    }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedAt
    {
        get => new TerraformReference<string>(this, "last_updated_at");
    }

    /// <summary>
    /// The managed_account_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedAccountId
    {
        get => new TerraformReference<string>(this, "managed_account_id");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
