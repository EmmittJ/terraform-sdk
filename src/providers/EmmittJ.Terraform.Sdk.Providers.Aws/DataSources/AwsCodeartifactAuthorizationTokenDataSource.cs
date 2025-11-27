using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codeartifact_authorization_token Terraform data source.
/// Retrieves information about a aws_codeartifact_authorization_token.
/// </summary>
public partial class AwsCodeartifactAuthorizationTokenDataSource(string name) : TerraformDataSource("aws_codeartifact_authorization_token", name)
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformValue<string> DomainOwner
    {
        get => new TerraformReference<string>(this, "domain_owner");
        set => SetArgument("domain_owner", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DurationSeconds
    {
        get => new TerraformReference<double>(this, "duration_seconds");
        set => SetArgument("duration_seconds", value);
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
    /// The authorization_token attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationToken
    {
        get => new TerraformReference<string>(this, "authorization_token");
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
    }

}
