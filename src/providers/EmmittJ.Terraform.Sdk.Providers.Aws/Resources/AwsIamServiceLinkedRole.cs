using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_linked_role resource.
/// </summary>
public class AwsIamServiceLinkedRole : TerraformResource
{
    public AwsIamServiceLinkedRole(string name) : base("aws_iam_service_linked_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("create_date");
        SetOutput("name");
        SetOutput("path");
        SetOutput("unique_id");
        SetOutput("aws_service_name");
        SetOutput("custom_suffix");
        SetOutput("description");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The aws_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsServiceName is required")]
    public required TerraformProperty<string> AwsServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_service_name");
        set => SetProperty("aws_service_name", value);
    }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    public TerraformProperty<string> CustomSuffix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_suffix");
        set => SetProperty("custom_suffix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
