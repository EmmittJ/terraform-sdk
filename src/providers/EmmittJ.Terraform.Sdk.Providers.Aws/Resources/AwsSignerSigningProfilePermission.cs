using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_signer_signing_profile_permission resource.
/// </summary>
public class AwsSignerSigningProfilePermission : TerraformResource
{
    public AwsSignerSigningProfilePermission(string name) : base("aws_signer_signing_profile_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("id");
        SetOutput("principal");
        SetOutput("profile_name");
        SetOutput("profile_version");
        SetOutput("region");
        SetOutput("statement_id");
        SetOutput("statement_id_prefix");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
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
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_name");
        set => SetProperty("profile_name", value);
    }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformProperty<string> ProfileVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_version");
        set => SetProperty("profile_version", value);
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
    /// The statement_id attribute.
    /// </summary>
    public TerraformProperty<string> StatementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_id");
        set => SetProperty("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformProperty<string> StatementIdPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_id_prefix");
        set => SetProperty("statement_id_prefix", value);
    }

}
