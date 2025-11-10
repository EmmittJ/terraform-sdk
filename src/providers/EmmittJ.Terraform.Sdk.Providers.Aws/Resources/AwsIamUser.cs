using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user resource.
/// </summary>
public class AwsIamUser : TerraformResource
{
    public AwsIamUser(string name) : base("aws_iam_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("unique_id");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("name");
        SetOutput("path");
        SetOutput("permissions_boundary");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// Delete user even if it has non-Terraform-managed IAM access keys, login profile or MFA devices
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformProperty<string> PermissionsBoundary
    {
        get => GetRequiredOutput<TerraformProperty<string>>("permissions_boundary");
        set => SetProperty("permissions_boundary", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
