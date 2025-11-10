using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeartifact_authorization_token.
/// </summary>
public class AwsCodeartifactAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsCodeartifactAuthorizationTokenDataSource(string name) : base("aws_codeartifact_authorization_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authorization_token");
        SetOutput("expiration");
        SetOutput("domain");
        SetOutput("domain_owner");
        SetOutput("duration_seconds");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformProperty<string> DomainOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_owner");
        set => SetProperty("domain_owner", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DurationSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration_seconds");
        set => SetProperty("duration_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    public TerraformExpression AuthorizationToken => this["authorization_token"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
