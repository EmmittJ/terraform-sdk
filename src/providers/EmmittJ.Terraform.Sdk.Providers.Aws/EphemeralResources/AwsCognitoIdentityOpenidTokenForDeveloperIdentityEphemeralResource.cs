using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_openid_token_for_developer_identity ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource : TerraformEphemeralResource
{
    public AwsCognitoIdentityOpenidTokenForDeveloperIdentityEphemeralResource(string name) : base("aws_cognito_identity_openid_token_for_developer_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("token");
        SetOutput("identity_id");
        SetOutput("identity_pool_id");
        SetOutput("logins");
        SetOutput("principal_tags");
        SetOutput("region");
        SetOutput("token_duration");
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformProperty<string> IdentityPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_pool_id");
        set => SetProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The logins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Logins is required")]
    public Dictionary<string, TerraformProperty<string>> Logins
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("logins");
        set => SetProperty("logins", value);
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> PrincipalTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("principal_tags");
        set => SetProperty("principal_tags", value);
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
    /// The token_duration attribute.
    /// </summary>
    public TerraformProperty<double> TokenDuration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("token_duration");
        set => SetProperty("token_duration", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformExpression Token => this["token"];

}
