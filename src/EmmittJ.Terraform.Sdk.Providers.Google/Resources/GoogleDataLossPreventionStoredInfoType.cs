using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_loss_prevention_stored_info_type resource.
/// </summary>
public class GoogleDataLossPreventionStoredInfoType : TerraformResource
{
    public GoogleDataLossPreventionStoredInfoType(string name) : base("google_data_loss_prevention_stored_info_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A description of the info type.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User set display name of the info type.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The parent of the info type in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformProperty<string>? StoredInfoTypeId
    {
        get => GetProperty<TerraformProperty<string>>("stored_info_type_id");
        set => this.WithProperty("stored_info_type_id", value);
    }

    /// <summary>
    /// The resource name of the info type. Set by the server.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
