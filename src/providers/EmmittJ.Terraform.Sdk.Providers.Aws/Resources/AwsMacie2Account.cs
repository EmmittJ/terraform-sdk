using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_macie2_account Terraform resource.
/// Manages a aws_macie2_account resource.
/// </summary>
public partial class AwsMacie2Account(string name) : TerraformResource("aws_macie2_account", name)
{
    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformValue<string> FindingPublishingFrequency
    {
        get => new TerraformReference<string>(this, "finding_publishing_frequency");
        set => SetArgument("finding_publishing_frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
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
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceRole
    {
        get => new TerraformReference<string>(this, "service_role");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

}
